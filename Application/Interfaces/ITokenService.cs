using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Student infoStudnet);

    }
}
