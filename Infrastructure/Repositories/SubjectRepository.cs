using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;

namespace Infrastructure.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(DB db) : base(db)
        {
        }
    }
}
