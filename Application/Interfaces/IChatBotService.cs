using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IChatBotService
    {
        Task<string> AskQuestionAsync(string message);
        Task AddMessageAsync(ChatMessage chatMessage);
        Task<List<ChatMessage>> GetMessagesStudentAsync(Expression<Func<ChatMessage, bool>> func);
    }
}
