using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IChatBotRepository
    {
        Task AddMessageAsync(ChatMessage chatMessage);
        Task<List<ChatMessage>> GetMessagesStudentAsync(Expression<Func<ChatMessage, bool>> func);
    }
}
