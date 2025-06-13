using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;
using Application.Interfaces;
using ChatHistory = Domain.Entities.ChatHistory;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ChatController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ChatController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpPost("Chat-Bot")]
        public async Task<IActionResult> ChatBot(ChatBotDTO chatBotDTO)
        {
            if (string.IsNullOrWhiteSpace(chatBotDTO.question))
                return BadRequest("Message is required.");


            if (chatBotDTO.ChatId != 0)
            {
                string response = await _serviceManager.ChatBotService.AskQuestionAsync(chatBotDTO.question);

                var isFound = await _serviceManager.ChatHistoryService.CheckTitle(x => x.Id == chatBotDTO.ChatId && x.Title == null);
                if (isFound)
                {
                    var chathistory = new ChatHistory
                    {
                        Id = chatBotDTO.ChatId,
                        Title = chatBotDTO.question,
                    };
                    await _serviceManager.ChatHistoryService.UpdateChatAsync(chathistory);
                }

                var chatMessage = new ChatMessage
                {
                    ChatHistoryId = chatBotDTO.ChatId,
                    Question = chatBotDTO.question,
                    Answer = response,
                    StudentId = int.Parse(User.FindFirstValue("id")!)
                };
                await _serviceManager.ChatBotService.AddMessageAsync(chatMessage);
                return Ok(response);
            }
            return BadRequest(new ApiResponse
            {
                Message = "Chat ID is required."
            });
        }


        [Authorize]
        [HttpGet("Chat-Bot/Get-Message/{ChatId}")]
        public async Task<IActionResult> GetChatHistory(int ChatId)
        {
            var chatHistory = (await _serviceManager.ChatBotService
                .GetMessagesStudentAsync(x => x.StudentId == int.Parse(User.FindFirstValue("id")!) && x.ChatHistoryId == ChatId))
                .Select(g => new
                {
                    g.Question,
                    g.Answer
                });
            if (chatHistory == null || !chatHistory.Any())
            {
                return NotFound(new ApiResponse
                {
                    Message = "No chat history found."
                });
            }
            return Ok(new ApiResponse
            {
                Data = chatHistory
            });

        }

        [Authorize]
        [HttpPost("Chat-Bot/NewChat")]
        public async Task<IActionResult> NewChat()
        {
            var studentId = int.Parse(User.FindFirstValue("id")!);

            var chat = new ChatHistory
            {
                StudentId = studentId,
                CreatedAt = DateTime.UtcNow
            };

            await _serviceManager.ChatHistoryService.AddChatAsync(chat);

            return Ok(new ApiResponse
            {
                Message = "New chat has been created successfully",
                Data = chat.Id
            });
        }

        [Authorize]
        [HttpGet("Chat-Bot/History")]
        public async Task<IActionResult> GetChatHistory()
        {
            var StudentId = int.Parse(User.FindFirstValue("id")!);
            var chatHistory = (await _serviceManager.ChatHistoryService.
                GetChatHistoryAsync(x => x.StudentId == StudentId && x.Title != null))
                .Select(g =>new {g.Id , g.Title });
                
            return Ok(chatHistory);
        }

    }
}
