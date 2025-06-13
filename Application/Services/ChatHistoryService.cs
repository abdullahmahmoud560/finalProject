using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class ChatHistoryService : IChatHistoryService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ChatHistoryService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddChatAsync(ChatHistory chat)
        {
            if (chat == null)
            {
                throw new ArgumentNullException(nameof(chat), "Chat history cannot be null.");
            }
            await _repositoryManager.ChatHistory.AddChatAsync(chat);
        }

        public async Task<bool> CheckTitle(Expression<Func<ChatHistory, bool>> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func), "Expression cannot be null.");
            }
            return await _repositoryManager.ChatHistory.CheckTitle(func);
        }

        public async Task<List<ChatHistory>> GetChatHistoryAsync(Expression<Func<ChatHistory, bool>> func)
        {
            return await _repositoryManager.ChatHistory.GetChatHistoryAsync(func);
        }

        public async Task UpdateChatAsync(ChatHistory chatHistory)
        {
            if (string.IsNullOrWhiteSpace(chatHistory.Title))
            {
                throw new ArgumentException("Title cannot be null or empty.", nameof(chatHistory.Title));
            }
            
            await _repositoryManager.ChatHistory.UpdateChatAsync(chatHistory);
        }
    }
}
