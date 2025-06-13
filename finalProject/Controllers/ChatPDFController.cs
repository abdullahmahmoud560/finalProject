using System.Security.Claims;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ChatPDFController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ChatPDFController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpPost("Upload-PDF")]
        public async Task<IActionResult> UploadFile(IFormFile file , int ChatId)
        {
            var userId = User.FindFirst("id")?.Value;

            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            try
            {
                using var originalStream = file.OpenReadStream();
                using var memoryStream = new MemoryStream();
                await originalStream.CopyToAsync(memoryStream);

                memoryStream.Position = 0;
                var upload = new UplaodDTO
                {
                    Content = new MemoryStream(memoryStream.ToArray()), 
                    FileName = file.FileName,
                    ContentType = file.ContentType
                };

                var result = await _serviceManager.ChatPDFService.UploadFileAsync(upload);
                if (string.IsNullOrEmpty(result))
                    return BadRequest("File upload failed.");

                var saveFile = new SaveFile
                {
                    Content = new MemoryStream(memoryStream.ToArray()),
                    FileName = file.FileName,
                    ChatId = ChatId,
                    StudentId = int.Parse(userId!)
                };

                await _serviceManager.ChatPDFService.SaveFileAsync(saveFile);

                return Ok(file.FileName);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [Authorize]
        [HttpPost("Ask-Question")]
        public async Task<IActionResult> AskQuestion([FromBody] ChatDPFDTO chatDPFDTO)
        {
            if (chatDPFDTO == null || string.IsNullOrEmpty(chatDPFDTO.fileName) || string.IsNullOrEmpty(chatDPFDTO.question))
            {
                return BadRequest("Invalid request data.");
            }
            try
            {
                var response = await _serviceManager.ChatPDFService.AskQuestionAsync(chatDPFDTO);
                if (string.IsNullOrEmpty(response))
                {
                    return BadRequest("Failed to get an answer.");
                }

                var isFound = await _serviceManager.ChatPDFHistoryService.CheckTitle(x => x.Id == chatDPFDTO.ChatId && x.Title == null);
                if (isFound)
                {
                    var chathistory = new ChatHistoryPDF
                    {
                        Id = chatDPFDTO.ChatId,
                        Title = chatDPFDTO.question,
                    };
                    await _serviceManager.ChatPDFHistoryService.UpdateChatAsync(chathistory);
                }

                var chatMessage = new ChatMessagePDF
                {
                    ChatId = chatDPFDTO.ChatId,
                    Question = chatDPFDTO.question,
                    Answer = response,
                    StudentId = int.Parse(User.FindFirstValue("id")!)
                };
                await _serviceManager.ChatPDFService.AddMessageAsync(chatMessage);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [Authorize]
        [HttpGet("Chat-PDF/Get-Message/{ChatId}")]
        public async Task<IActionResult> GetChatHistory(int ChatId)
        {
            var studentId = int.Parse(User.FindFirstValue("id")!);

            var messages = await _serviceManager.ChatPDFService
                .GetMessagesStudentAsync(x => x.StudentId == studentId && x.ChatId == ChatId);

            var files = await _serviceManager.ChatPDFService
                .GetFileAsync(x => x.ChatId == ChatId && x.StudentId == studentId);

            if ((messages == null || !messages.Any()) && (files == null || !files.Any()))
            {
                return NotFound(new ApiResponse
                {
                    Message = "No chat history found."
                });
            }

            var messageItems = messages.Select(m => new
            {
                Type = "Message",
                Question = m.Question,
                Answer = m.Answer,
                FileName = string.Empty,
                FilePath = string.Empty,
                CreatedAt = m.CreatedAt
            });

            var fileItems = files.Select(f => new
            {
                Type = "File",
                Question = string.Empty,
                Answer = string.Empty,
                FileName = f.FileName,
                FilePath = f.FilePath,
                CreatedAt = f.CreatedAt
            });

            var combined = messageItems
                .Concat(fileItems)
                .OrderBy(x => x.CreatedAt)
                .ToList();

            return Ok(new ApiResponse
            {
                Data = combined
            });
        }


        [Authorize]
        [HttpPost("Chat-PDF/NewChat")]
        public async Task<IActionResult> NewChat()
        {
            var studentId = int.Parse(User.FindFirstValue("id")!);

            var chat = new ChatHistoryPDF
            {
                StudentId = studentId,
                CreatedAt = DateTime.UtcNow
            };

            await _serviceManager.ChatPDFHistoryService.AddChatAsync(chat);

            return Ok(new ApiResponse
            {
                Message = "New chat has been created successfully",
                Data = chat.Id
            });
        }

        [Authorize]
        [HttpGet("Chat-PDF/History")]
        public async Task<IActionResult> GetChatHistory()
        {
            var StudentId = int.Parse(User.FindFirstValue("id")!);
            var chatHistory = (await _serviceManager.ChatPDFHistoryService.
                GetChatHistoryAsync(x => x.StudentId == StudentId && x.Title != null))
                .Select(g => new { g.Id, g.Title });

            return Ok(chatHistory);
        }

    }
}
