using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class CourseService : ICourseService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CourseService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<Show_Subjects>> AI_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.AI_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> AI_Electives(int StudentID)
        {
            return await _repositoryManager.Course.AI_Electives(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> CS_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.CS_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> CS_Electives(int StudentID)
        {
            return await _repositoryManager.Course.CS_Electives(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> Faculty_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.Faculty_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> Faculty_Electives(int StudentID)
        {
            return await _repositoryManager.Course.Faculty_Electives(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> General_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.General_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> General_Electives(int StudentID)
        {
            return await _repositoryManager.Course.General_Electives(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> IS_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.IS_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> IS_Electives(int StudentID)
        {
            return await _repositoryManager.Course.IS_Electives(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> IT_Compulsories(int StudentID)
        {
            return await _repositoryManager.Course.IT_Compulsories(StudentID);
        }

        public async Task<IEnumerable<Show_Subjects>> IT_Electives(int StudentID)
        {
            return await _repositoryManager.Course.IT_Electives(StudentID);
        }
    }
}
