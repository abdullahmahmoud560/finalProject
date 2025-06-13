using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IChatPDFHistoryService
    {
        Task AddChatAsync(ChatHistoryPDF chat);
        Task UpdateChatAsync(ChatHistoryPDF chat);
        Task<bool> CheckTitle(Expression<Func<ChatHistoryPDF, bool>> func);
        Task<List<ChatHistoryPDF>> GetChatHistoryAsync(Expression<Func<ChatHistoryPDF, bool>> func);
    }
}
