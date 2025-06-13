using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITokenRepository
    {
        string GenerateToken(Student student);
    }
}
