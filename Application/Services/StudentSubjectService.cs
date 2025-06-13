using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class StudentSubjectService : IStudentSubjectService
    {
        public IRepositoryManager _repositoryManager;

        public StudentSubjectService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddStudentSubject(StudentSubject studentSubject)
        {
            await _repositoryManager.StudentSubject.AddAsync(studentSubject);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteStudentSubject(StudentSubject studentSubject)
        {
            await _repositoryManager.StudentSubject.DeleteAsync(studentSubject);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<StudentSubject>> GetAllStudentSubjectsAsync()
        {
            return  await _repositoryManager.StudentSubject.GetAllAsync();
        }

        public async Task<IEnumerable<StudentSubject>> GetByConditionAsync(Expression<Func<StudentSubject, bool>> expression)
        {
            return await _repositoryManager.StudentSubject.GetByConditionAsync(expression);
        }

        public async Task UpdateStudentSubject(StudentSubject studentSubject)
        {
            await _repositoryManager.StudentSubject.UpdateAsync(studentSubject);
            await _repositoryManager.SaveAsync();
        }

        
    }
}
