using finalProject.Data;
using finalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace finalProject.DTO
{
    public class Functions
    {
        private DB _db;

        public Functions(DB db)
        {
            _db = db;
        }

        public async Task< int> CalculateTotalHoursGeneral(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.general_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.general_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
        public async Task< int> CalculateTotalHoursFaculty(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.faculty_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.faculty_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
        public async Task< int> CalculateTotalHoursCS(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.cS_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.cS_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
        public async Task< int> CalculateTotalHoursIS(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.iS_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.iS_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
        public async Task< int> CalculateTotalHoursIT(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.iT_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.iT_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
        public async Task< int> CalculateTotalHoursAI(List<StudentSubject> allSubjects)
        {
            int half1 = 0;
            int half2 = 0;
            foreach (var subject in allSubjects)
            {
                if (subject.SubjectCode != null)
                {
                    half1 += await _db.aI_Compulsories
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null

                    half2 += await _db.aI_Electives
                        .Where(l => l.code == subject.SubjectCode)
                        .SumAsync(l => l.hours ?? 0);  // نضيف 0 إذا كانت الساعات null
                }
            }
            return half2+half1;
        }
    }
}
