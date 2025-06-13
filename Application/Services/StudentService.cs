using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class StudentService : IStudentService
    {
        public IRepositoryManager _repositoryManager;

        public StudentService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddStudent(Student student)
        {
           await _repositoryManager.Student.AddAsync(student);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteStudent(Student student)
        {
            await _repositoryManager.Student.DeleteAsync(student);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            var result = await _repositoryManager.Student.GetAllAsync();
            return result;
        }

        public async Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression)
        {
            var result = await _repositoryManager.Student.GetByConditionAsync(expression);
            return result;
        }

        public async Task UpdateStudent(Student student)
        {
            await _repositoryManager.Student.UpdateAsync(student);
            await _repositoryManager.SaveAsync();
        }

    }
}
