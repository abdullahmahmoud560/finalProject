using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private DB _db;

        public CourseRepository(DB db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Show_Subjects>> AI_Compulsories(int StudentID)
        {
            var courses = await _db.aI_Compulsories
                  .GroupJoin(
                      _db.StudentSubjects.Where(ss => ss.StudentId == StudentID),
                      course => course.code,
                      studentSubject => studentSubject.SubjectCode,
                      (course, studentSubjects) => new Show_Subjects
                      {
                          course_Name_ar = course.course_Name_ar,
                          code = course.code,
                          course_Name_en = course.course_Name_en,
                          prerequest_en = course.prerequest_en,
                          prerequest_ar = course.prerequest_ar,
                          hours = course.hours,
                          grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                      })
                      .ToListAsync();
            return courses.AsEnumerable(); 
        }

        public async Task<IEnumerable<Show_Subjects>> AI_Electives(int studentID)
        {
            var courses = await _db.aI_Electives
                              .GroupJoin(
                                  _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
                                  course => course.code,
                                  studentSubject => studentSubject.SubjectCode,
                                  (course, studentSubjects) => new Show_Subjects
                                  {
                                      code = course.code,
                                      hours = course.hours,
                                      course_Name_en = course.course_Name_en,
                                      prerequest_en = course.prerequest_en,
                                      course_Name_ar = course.course_Name_ar,
                                      prerequest_ar = course.prerequest_ar,
                                      grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                                  })
                                  .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> CS_Compulsories(int studentID)
        {
            var courses = await _db.cS_Compulsories
                  .GroupJoin(
                      _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
                      course => course.code,
                      studentSubject => studentSubject.SubjectCode,
                      (course, studentSubjects) => new Show_Subjects
                      {
                          code = course.code,
                          hours = course.hours,
                          course_Name_en = course.course_Name_en,
                          course_Name_ar = course.course_Name_ar,
                          prerequest_en = course.prerequest_en,
                          prerequest_ar = course.prerequest_ar,
                          grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                      })
                      .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> CS_Electives(int studentID)
        {
            var courses = await _db.cS_Electives
                  .GroupJoin(
                      _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
                      course => course.code,
                      studentSubject => studentSubject.SubjectCode,
                      (course, studentSubjects) => new Show_Subjects
                      {
                          code = course.code,
                          hours = course.hours,
                          course_Name_en = course.course_Name_en,
                          course_Name_ar = course.course_Name_ar,
                          prerequest_en = course.prerequest_en,
                          prerequest_ar = course.prerequest_ar,
                          grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                      })
                      .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> Faculty_Compulsories(int studentID)
        {
            var courses = await _db.faculty_Compulsories
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              hours = course.hours,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> Faculty_Electives(int studentID)
        {
            var courses = await _db.faculty_Electives
                  .GroupJoin(
                      _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
                      course => course.code,
                      studentSubject => studentSubject.SubjectCode,
                      (course, studentSubjects) => new Show_Subjects
                      {
                          code = course.code,
                          course_Name_en = course.course_Name_en,
                          course_Name_ar = course.course_Name_ar,
                          prerequest_en = course.prerequest_en,
                          prerequest_ar = course.prerequest_ar,
                          hours = course.hours,
                          grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                      })
                      .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> General_Compulsories(int studentID)
        {
            var courses = await _db.general_Compulsories
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              hours = course.hours,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> General_Electives(int studentID)
        {
            var courses = await _db.general_Electives
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              hours = course.hours,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> IS_Compulsories(int studentID)
        {
            var courses = await _db.iS_Compulsories
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              hours = course.hours,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> IS_Electives(int studentID)
        {
            var courses = await _db.iS_Electives
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              hours = course.hours,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> IT_Compulsories(int studentID)
        {
            var courses = await _db.iT_Compulsories
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              hours = course.hours,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }

        public async Task<IEnumerable<Show_Subjects>> IT_Electives(int studentID)
        {
            var courses = await _db.iT_Electives
      .GroupJoin(
          _db.StudentSubjects.Where(ss => ss.StudentId == studentID),
          course => course.code,
          studentSubject => studentSubject.SubjectCode,
          (course, studentSubjects) => new Show_Subjects
          {
              code = course.code,
              hours = course.hours,
              course_Name_en = course.course_Name_en,
              course_Name_ar = course.course_Name_ar,
              prerequest_en = course.prerequest_en,
              prerequest_ar = course.prerequest_ar,
              grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
          })
          .ToListAsync();
            return courses.AsEnumerable();
        }
    }
}
