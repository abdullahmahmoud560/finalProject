using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IChatHistoryRepository
    {
        Task AddChatAsync(ChatHistory chat);
        Task UpdateChatAsync(ChatHistory chat);
        Task<bool> CheckTitle(Expression<Func<ChatHistory, bool>> func);
        Task<List<ChatHistory>> GetChatHistoryAsync(Expression<Func<ChatHistory, bool>> func);
    }
}
