using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;

namespace Infrastructure.Repositories
{
    public class StudentSubjectRepository : RepositoryBase<StudentSubject>, IStudentSubjectRepository
    {
        public StudentSubjectRepository(DB db) : base(db)
        {
        }
    }
}
