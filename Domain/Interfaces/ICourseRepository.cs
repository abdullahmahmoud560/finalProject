using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Show_Subjects>> AI_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> AI_Electives(int StudentID);
        Task<IEnumerable<Show_Subjects>> CS_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> CS_Electives(int StudentID);
        Task<IEnumerable<Show_Subjects>> IS_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> IS_Electives(int StudentID);
        Task<IEnumerable<Show_Subjects>> IT_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> IT_Electives(int StudentID);
        Task<IEnumerable<Show_Subjects>> Faculty_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> Faculty_Electives(int StudentID);
        Task<IEnumerable<Show_Subjects>> General_Compulsories(int StudentID);
        Task<IEnumerable<Show_Subjects>> General_Electives(int StudentID);

    }
}
