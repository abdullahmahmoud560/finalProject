using System.Text.Json;
using System.Text;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public sealed class ChatBotService : IChatBotService
    {
        private readonly HttpClient _httpClient;
        private readonly IRepositoryManager _repositoryManager;

        public ChatBotService(HttpClient httpClient, IRepositoryManager repositoryManager)
        {
            _httpClient = new HttpClient { Timeout = TimeSpan.FromMinutes(10) };
            _repositoryManager = repositoryManager;
        }

        public async Task AddMessageAsync(ChatMessage chatMessage)
        {
            await _repositoryManager.ChatBot.AddMessageAsync(chatMessage);
        }

        public async Task<string> AskQuestionAsync(string message)
        {
            var requestBody = new { question = message };
            string jsonBody = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://hadheedo-apif.hf.space/ask", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(responseContent);
            if (doc.RootElement.TryGetProperty("answer", out var answerElement))
            {
                return answerElement.GetString()!; 
            }

            return "لم يتم العثور على إجابة في الرد.";
        }

        public async Task<List<ChatMessage>> GetMessagesStudentAsync(Expression<Func<ChatMessage, bool>> func)
        {
            return await _repositoryManager.ChatBot.GetMessagesStudentAsync(func);
        }

    }
}
