using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using static Shared.DataTransferObjects;

namespace Application.Interfaces
{
    public interface IChatPDFService
    {
        Task<string> UploadFileAsync(UplaodDTO uplaodDTO);
        Task SaveFileAsync(SaveFile save);
        Task<string> AskQuestionAsync(ChatDPFDTO chatDPFDTO);
        Task AddMessageAsync(ChatMessagePDF chatMessage);
        Task<List<ChatMessagePDF>> GetMessagesStudentAsync(Expression<Func<ChatMessagePDF, bool>> func);
        Task<List<FilePDF>> GetFileAsync(Expression<Func<FilePDF, bool>> func);
    }
}
