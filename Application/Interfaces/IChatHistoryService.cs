using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IChatHistoryService
    {
        Task AddChatAsync(ChatHistory chat);
        Task UpdateChatAsync(ChatHistory chat);
        Task<bool> CheckTitle(Expression<Func<ChatHistory, bool>> func);
        Task<List<ChatHistory>> GetChatHistoryAsync(Expression<Func<ChatHistory, bool>> func);
    }
}
