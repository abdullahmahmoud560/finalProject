using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudentSubjectService
    {
        Task<IEnumerable<StudentSubject>> GetAllStudentSubjectsAsync();
        Task<IEnumerable<StudentSubject>> GetByConditionAsync(Expression<Func<StudentSubject, bool>> expression);
        Task AddStudentSubject(StudentSubject studentSubject);
        Task UpdateStudentSubject(StudentSubject studentSubject);
        Task DeleteStudentSubject(StudentSubject studentSubject);
    }
}
