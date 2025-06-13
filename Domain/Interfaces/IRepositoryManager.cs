namespace Domain.Interfaces
{
    public interface IRepositoryManager
    {
        IStudentRepository Student { get; }
        ISubjectRepository Subject { get; }
        IStudentSubjectRepository StudentSubject { get; }
        IFunctionRepository FunctionRepository { get; }
        ITokenRepository TokenRepository { get; }
        ICourseRepository Course { get; }
        IChatBotRepository ChatBot { get; }
        IChatHistoryRepository ChatHistory { get; }
        IChatPDFRepository ChatPDF { get; }
        IChatPDFHistoryRepository ChatPDFHistory { get; }
        Task SaveAsync();
    }
}
