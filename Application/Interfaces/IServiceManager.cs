namespace Application.Interfaces
{
    public interface IServiceManager
    {
        IStudentService StudentService { get; }
        ISubjectService SubjectService { get; }
        IStudentSubjectService StudentSubjectService { get; }
        ITokenService TokenService { get; }
        IEmailService EmailService { get; }
        IFunctionService FunctionService { get; }
        ICourseService CourseService { get; }
        IChatBotService ChatBotService { get; }
        IChatHistoryService ChatHistoryService { get; }
        IChatPDFService ChatPDFService { get; }
        IChatPDFHistoryService ChatPDFHistoryService { get; }
    }
}
