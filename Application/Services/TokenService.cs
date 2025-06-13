using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class TokenService : ITokenService
    {
        private readonly IRepositoryManager _repository;
        public TokenService(IRepositoryManager repository)
        {
            _repository = repository;
        }
        public string GenerateToken(Student infoStudnet)
        {
           return _repository.TokenRepository.GenerateToken(infoStudnet);
        }
    }
}
