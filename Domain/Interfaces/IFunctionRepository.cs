using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IFunctionRepository
    {
        public  Task<int> CalculateTotalHoursGeneral(List<StudentSubject> allSubjects);
        public  Task<int> CalculateTotalHoursFaculty(List<StudentSubject> allSubjects);
        public  Task<int> CalculateTotalHoursCS(List<StudentSubject> allSubjects);
        public  Task<int> CalculateTotalHoursIS(List<StudentSubject> allSubjects);
        public  Task<int> CalculateTotalHoursIT(List<StudentSubject> allSubjects);
        public  Task<int> CalculateTotalHoursAI(List<StudentSubject> allSubjects);
    }
}
