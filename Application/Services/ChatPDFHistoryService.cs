using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class ChatPDFHistoryService : IChatPDFHistoryService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ChatPDFHistoryService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddChatAsync(ChatHistoryPDF chat)
        {
            if (chat == null)
            {
                throw new ArgumentNullException(nameof(chat), "Chat history cannot be null.");
            }
            await _repositoryManager.ChatPDFHistory.AddChatAsync(chat);
        }

        public async Task<bool> CheckTitle(Expression<Func<ChatHistoryPDF, bool>> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func), "Expression cannot be null.");
            }
            return await _repositoryManager.ChatPDFHistory.CheckTitle(func);
        }

        public async Task<List<ChatHistoryPDF>> GetChatHistoryAsync(Expression<Func<ChatHistoryPDF, bool>> func)
        {
            return await _repositoryManager.ChatPDFHistory.GetChatHistoryAsync(func);
        }

        public async Task UpdateChatAsync(ChatHistoryPDF chatHistory)
        {
            if (string.IsNullOrWhiteSpace(chatHistory.Title))
            {
                throw new ArgumentException("Title cannot be null or empty.", nameof(chatHistory.Title));
            }

            await _repositoryManager.ChatPDFHistory.UpdateChatAsync(chatHistory);
        }
    }
}
