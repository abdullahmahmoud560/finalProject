using Application.Services;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;

namespace finalProject.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IStudentRepository> _studentRepository;
        private readonly Lazy<ISubjectRepository> _subjectRepository;
        private readonly Lazy<IStudentSubjectRepository> _studentSubjectRepository;
        private readonly Lazy<ICourseRepository> _courseRepository;
        private readonly Lazy<IFunctionRepository> _functionRepository;
        private readonly Lazy<ITokenRepository> _tokenRepository;
        private readonly Lazy<IChatBotRepository> _chatBotRepository;
        private readonly Lazy<IChatHistoryRepository> _chatBotHistory;
        private readonly Lazy<IChatPDFRepository> _chatPDFRepository;
        private readonly Lazy<IChatPDFHistoryRepository> _chatPDFHistoryRepository;
        private readonly DB _db;

        public RepositoryManager(DB db ,IConfiguration configuration)
        {
            _db = db;
            _studentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(_db));
            _subjectRepository = new Lazy<ISubjectRepository>(() => new SubjectRepository(_db));
            _studentSubjectRepository = new Lazy<IStudentSubjectRepository>(() => new StudentSubjectRepository(_db));
            _courseRepository = new Lazy<ICourseRepository>(() => new CourseRepository(_db));
            _functionRepository = new Lazy<IFunctionRepository>(() => new FunctionRepository(_db));
            _tokenRepository = new Lazy<ITokenRepository>(() => new TokenRepository(configuration));
            _chatBotRepository = new Lazy<IChatBotRepository>(() => new ChatBotRepository(_db));
            _chatBotHistory = new Lazy<IChatHistoryRepository>(() => new ChatHistoryRepository(_db));
            _chatPDFRepository = new Lazy<IChatPDFRepository>(() => new ChatPDFRepository(_db));
            _chatPDFHistoryRepository = new Lazy<IChatPDFHistoryRepository>(() => new ChatPDFHistoryRepository(_db));
        }

        public IStudentRepository Student => _studentRepository.Value;

        public ISubjectRepository Subject => _subjectRepository.Value;

        public IStudentSubjectRepository StudentSubject => _studentSubjectRepository.Value;

        public IFunctionRepository FunctionRepository => _functionRepository.Value;

        public ITokenRepository TokenRepository =>_tokenRepository.Value;

        public ICourseRepository Course => _courseRepository.Value;
        public IChatBotRepository ChatBot => _chatBotRepository.Value;
        public IChatHistoryRepository ChatHistory => _chatBotHistory.Value;
        public IChatPDFRepository ChatPDF => _chatPDFRepository.Value;
        public IChatPDFHistoryRepository ChatPDFHistory => _chatPDFHistoryRepository.Value;
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
