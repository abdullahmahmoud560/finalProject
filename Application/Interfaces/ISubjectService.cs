using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface ISubjectService
    {
        Task<IEnumerable<Subject>> GetAllSubjectAsync();
        Task<IEnumerable<Subject>> GetByConditionAsync(Expression<Func<Subject, bool>> expression);
        Task UpdateSubject(Subject subject);
        Task AddSubject(Subject subject);
        Task DeleteSubject(Subject subject);
    }
}
