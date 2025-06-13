using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class SubjectService: ISubjectService
    {
        public IRepositoryManager _repositoryManager;
        public SubjectService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddSubject(Subject subject)
        {
            await _repositoryManager.Subject.AddAsync(subject);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteSubject(Subject subject)
        {
            await _repositoryManager.Subject.DeleteAsync(subject);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Subject>> GetAllSubjectAsync()
        {
            var subjects =  await _repositoryManager.Subject.GetAllAsync();
            return subjects;
        }

        public async Task<IEnumerable<Subject>> GetByConditionAsync(Expression<Func<Subject, bool>> expression)
        {
            var subjects = await _repositoryManager.Subject.GetByConditionAsync(expression);
            return subjects;
        }

        public async Task UpdateSubject(Subject subject)
        {
            await _repositoryManager.Subject.UpdateAsync(subject);
            await _repositoryManager.SaveAsync();
        }
    }
 
}
