using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;

namespace Infrastructure.Repositories
{
    public class StudentRepository: RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(DB db) : base(db)
        {
        }
    }
}
