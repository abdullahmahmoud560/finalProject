using System.Net.Http.Headers;
using System.Net.Http;
using Application.Interfaces;
using Shared;
using static Shared.DataTransferObjects;
using Domain.Interfaces;
using Domain.Entities;
using System.Linq.Expressions;
using System.Text.Json;

namespace Application.Services
{
    public class ChatPDFService : IChatPDFService
    {
        private HttpClient _httpClient;
        private IRepositoryManager _repositoryManager;

        public ChatPDFService(HttpClient httpClinet,IRepositoryManager repositoryManager)
        {
            _httpClient = httpClinet;
            _repositoryManager = repositoryManager;
        }

        public async Task<string> AskQuestionAsync(ChatDPFDTO chatDPFDTO)
        {
            var formData = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("filename", chatDPFDTO.fileName),
            new KeyValuePair<string, string>("question", chatDPFDTO.question)
            });

            var apiUrl = "https://mohamedhassan7862-pdf-chatbot.hf.space/ask/";

            try
            {
                var response = await _httpClient.PostAsync(apiUrl, formData);

                if (!response.IsSuccessStatusCode)
                    return $"API Error: {response.StatusCode}";

                var content = await response.Content.ReadAsStringAsync();

                using var doc = JsonDocument.Parse(content);
                if (doc.RootElement.TryGetProperty("answer", out var answerElement))
                {
                    return answerElement.GetString()!;
                }
                return "لم يتم العثور على إجابة في الرد.";
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }

        public async Task SaveFileAsync(SaveFile save)
        {
            if (save.Content == null || string.IsNullOrWhiteSpace(save.FileName))
                throw new ArgumentException("Invalid file data");

            save.Content.Position = 0;

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, save.FileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await save.Content.CopyToAsync(fileStream);
            }

            var filePDF = new FilePDF
            {
                FileName = save.FileName,
                FilePath = filePath,
                ChatId = save.ChatId,
                StudentId = save.StudentId,
            };

            await _repositoryManager.ChatPDF.SaveFileAsync(filePDF);
        }

        public async Task<string> UploadFileAsync(UplaodDTO uplaodDTO)
        {
            using var form = new MultipartFormDataContent();

            var fileContent = new StreamContent(uplaodDTO.Content!);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(uplaodDTO.ContentType!);

            form.Add(fileContent, "file", uplaodDTO.FileName!);

            var response = await _httpClient.PostAsync("https://mohamedhassan7862-pdf-chatbot.hf.space/upload/", form);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task AddMessageAsync(ChatMessagePDF chatMessage)
        {
            await _repositoryManager.ChatPDF.AddMessageAsync(chatMessage);
        }

        public async Task<List<ChatMessagePDF>> GetMessagesStudentAsync(Expression<Func<ChatMessagePDF, bool>> func)
        {
            return await _repositoryManager.ChatPDF.GetMessagesStudentAsync(func);
        }

        public async Task<List<FilePDF>> GetFileAsync(Expression<Func<FilePDF, bool>> func)
        {
            return await _repositoryManager.ChatPDF.GetFileAsync(func);
        }
    }
}
