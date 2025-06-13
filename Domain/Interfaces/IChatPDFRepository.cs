using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IChatPDFRepository
    {
        Task AddMessageAsync(ChatMessagePDF chatMessagePDF);
        Task SaveFileAsync(FilePDF filePDF);
        Task<List<ChatMessagePDF>> GetMessagesStudentAsync(Expression<Func<ChatMessagePDF, bool>> func);
        Task<List<FilePDF>> GetFileAsync(Expression<Func<FilePDF, bool>> func);
    }
}
