using Application.Interfaces;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IStudentService> _studentService;
        private readonly Lazy<ISubjectService> _subjectService;
        private readonly Lazy<IStudentSubjectService> _studentSubjectService;
        private readonly Lazy<IEmailService> _emailService;
        private readonly Lazy<IFunctionService> _functionService;
        private readonly Lazy<ITokenService> _tokenService;
        private readonly Lazy<ICourseService> _courseService;
        private readonly Lazy<IChatBotService> _chatBotService;
        private readonly Lazy<IChatHistoryService> _chatHistoryService;
        private readonly Lazy<IChatPDFService> _chatPDFService;
        private readonly Lazy<IChatPDFHistoryService> _chatPDFHistoryService;
        public ServiceManager(IRepositoryManager repository, IConfiguration configuration,HttpClient httpClient)
        {
            _studentService = new Lazy<IStudentService>(() => new StudentService(repository));
            _subjectService = new Lazy<ISubjectService>(() => new SubjectService(repository));
            _studentSubjectService = new Lazy<IStudentSubjectService>(() => new StudentSubjectService(repository));
            _emailService = new Lazy<IEmailService>(() => new EmailService(configuration));
            _functionService = new Lazy<IFunctionService> (() => new FunctionService(repository));
            _tokenService = new Lazy<ITokenService>(() => new TokenService(repository));
            _courseService = new Lazy<ICourseService>(() => new CourseService(repository));
            _chatBotService = new Lazy<IChatBotService>(() => new ChatBotService(httpClient,repository));
            _chatHistoryService = new Lazy<IChatHistoryService>(() => new ChatHistoryService(repository));
            _chatPDFService = new Lazy<IChatPDFService>(() => new ChatPDFService(httpClient,repository));
            _chatPDFHistoryService = new Lazy<IChatPDFHistoryService>(() => new ChatPDFHistoryService(repository));
        }
        public IStudentService StudentService => _studentService.Value;

        public ISubjectService SubjectService => _subjectService.Value;

        public IStudentSubjectService StudentSubjectService => _studentSubjectService.Value;

        public IEmailService EmailService => _emailService.Value;
        public IFunctionService FunctionService => _functionService.Value;

        public ITokenService TokenService => _tokenService.Value;
        public ICourseService CourseService => _courseService.Value;
        public IChatBotService ChatBotService => _chatBotService.Value;
        public IChatHistoryService ChatHistoryService => _chatHistoryService.Value;
        public IChatPDFService ChatPDFService => _chatPDFService.Value;
        public IChatPDFHistoryService ChatPDFHistoryService => _chatPDFHistoryService.Value;
    }
}
