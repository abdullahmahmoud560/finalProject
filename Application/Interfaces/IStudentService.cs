using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentAsync();
        Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression);
        Task UpdateStudent(Student student);
        Task AddStudent(Student student);
        Task DeleteStudent(Student student);
    }
}
