using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public sealed class FunctionService: IFunctionService
    {
        private readonly IRepositoryManager _repository;
        public FunctionService(IRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<int> CalculateTotalHoursGeneral(List<StudentSubject> allSubjects)
        {
           return await _repository.FunctionRepository.CalculateTotalHoursGeneral(allSubjects);
        }
        public async Task<int> CalculateTotalHoursFaculty(List<StudentSubject> allSubjects)
        {
            return await _repository.FunctionRepository.CalculateTotalHoursFaculty(allSubjects);
        }
        public async Task<int> CalculateTotalHoursCS(List<StudentSubject> allSubjects)
        {
            return  await _repository.FunctionRepository.CalculateTotalHoursCS(allSubjects);
        }

        public async Task<int> CalculateTotalHoursIS(List<StudentSubject> allSubjects)
        {
            return await _repository.FunctionRepository.CalculateTotalHoursIS(allSubjects);
        }

        public async Task<int> CalculateTotalHoursIT(List<StudentSubject> allSubjects)
        {
            return await _repository.FunctionRepository.CalculateTotalHoursIT(allSubjects);
        }

        public async Task<int> CalculateTotalHoursAI(List<StudentSubject> allSubjects)
        {
            return  await _repository.FunctionRepository.CalculateTotalHoursAI(allSubjects);
        }
    }
}
