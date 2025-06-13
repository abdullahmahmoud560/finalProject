using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class F_Compulsory_Configurations : IEntityTypeConfiguration<Faculty_Compulsory>
    {
        public void Configure(EntityTypeBuilder<Faculty_Compulsory> builder)
        {
            builder.HasData(
                new Faculty_Compulsory { code = "CS 111", course_Name_en = "Introduction to Computers", hours = 3, prerequest_en = "-", course_Name_ar = "مقدمة في الحاسوب", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "CS 112", course_Name_en = "Programming-1", hours = 3, prerequest_en = "Introduction to Computers", course_Name_ar = "برمجة 1", prerequest_ar = "مقدمة في الحاسوب" },
                new Faculty_Compulsory { code = "CS 213", course_Name_en = "Programming-2", hours = 3, prerequest_en = "Programming-1", course_Name_ar = "برمجة 2", prerequest_ar = "برمجة 1" },
                new Faculty_Compulsory { code = "CS 214", course_Name_en = "Data Structures", hours = 3, prerequest_en = "Programming-1", course_Name_ar = "هياكل البيانات", prerequest_ar = "برمجة 1" },
                new Faculty_Compulsory { code = "CS 221", course_Name_en = "Logic Design", hours = 3, prerequest_en = "-", course_Name_ar = "تصميم المنطق", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "CS 241", course_Name_en = "Operating Systems-1", hours = 3, prerequest_en = "Programming-1", course_Name_ar = "أنظمة التشغيل 1", prerequest_ar = "برمجة 1" },
                new Faculty_Compulsory { code = "CS 251", course_Name_en = "Software Engineering-1", hours = 3, prerequest_en = "Programming-1", course_Name_ar = "هندسة البرمجيات 1", prerequest_ar = "برمجة 1" },
                new Faculty_Compulsory { code = "CS 316", course_Name_en = "Algorithms", hours = 3, prerequest_en = "Data Structures", course_Name_ar = "الخوارزميات", prerequest_ar = "هياكل البيانات" },
                new Faculty_Compulsory { code = "IS 211", course_Name_en = "Database Systems-1", hours = 3, prerequest_en = "-", course_Name_ar = "نظم قواعد البيانات 1", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "IS 231", course_Name_en = "Fundamentals of Information Systems", hours = 3, prerequest_en = "-", course_Name_ar = "أساسيات نظم المعلومات", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "IS 240", course_Name_en = "Operations Research", hours = 3, prerequest_en = "-", course_Name_ar = "بحوث العمليات", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "IS 351", course_Name_en = "System Analysis and Design-1", hours = 3, prerequest_en = "Fundamentals of Information Systems", course_Name_ar = "تحليل وتصميم النظم 1", prerequest_ar = "أساسيات نظم المعلومات" },
                new Faculty_Compulsory { code = "IT 111", course_Name_en = "Electronics-1", hours = 3, prerequest_en = "-", course_Name_ar = "إلكترونيات 1", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "IT 221", course_Name_en = "Data Communication", hours = 3, prerequest_en = "Probability and Statistics-1", course_Name_ar = "اتصالات البيانات", prerequest_ar = "احتمالات وإحصاء 1" },
                new Faculty_Compulsory { code = "IT 222", course_Name_en = "Computer Networks-1", hours = 3, prerequest_en = "Database Systems-1", course_Name_ar = "شبكات الحاسوب 1", prerequest_ar = "نظم قواعد البيانات 1" },
                new Faculty_Compulsory { code = "IT 223", course_Name_en = "Internet Technology", hours = 3, prerequest_en = "-", course_Name_ar = "تقنيات الإنترنت", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "MA 111", course_Name_en = "Mathematics-1", hours = 3, prerequest_en = "-", course_Name_ar = "رياضيات 1", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "MA 112", course_Name_en = "Discrete Mathematics", hours = 3, prerequest_en = "-", course_Name_ar = "الرياضيات المتقطعة", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "MA 113", course_Name_en = "Mathematics–2", hours = 3, prerequest_en = "Mathematics-1", course_Name_ar = "رياضيات 2", prerequest_ar = "رياضيات 1" },
                new Faculty_Compulsory { code = "PH 111", course_Name_en = "Physics", hours = 3, prerequest_en = "-", course_Name_ar = "الفيزياء", prerequest_ar = "-" },
                new Faculty_Compulsory { code = "ST 121", course_Name_en = "Probability and Statistics-1", hours = 3, prerequest_en = "-", course_Name_ar = "احتمالات وإحصاء 1", prerequest_ar = "-" }
            );
        }
    }

    public class F_Elective_Configurations : IEntityTypeConfiguration<Faculty_Electives>
    {
        public void Configure(EntityTypeBuilder<Faculty_Electives> builder)
        {
            builder.HasData(
                new Faculty_Electives { code = "CS 313", course_Name_en = "Programming-3", hours = 3, prerequest_en = "Programming-2", course_Name_ar = "برمجة 3", prerequest_ar = "برمجة 2" },
                new Faculty_Electives { code = "HU 122", course_Name_en = "Fundamentals of Management", hours = 3, prerequest_en = "-", course_Name_ar = "أساسيات الإدارة", prerequest_ar = "-" },
                new Faculty_Electives { code = "IS 241", course_Name_en = "Modeling and Simulation", hours = 3, prerequest_en = "-", course_Name_ar = "النمذجة والمحاكاة", prerequest_ar = "-" },
                new Faculty_Electives { code = "IS 321", course_Name_en = "Projects Management", hours = 3, prerequest_en = "Operations Research", course_Name_ar = "إدارة المشاريع", prerequest_ar = "بحوث العمليات" },
                new Faculty_Electives { code = "IS 342", course_Name_en = "Simulation Languages", hours = 3, prerequest_en = "Modeling and Simulation", course_Name_ar = "لغات المحاكاة", prerequest_ar = "النمذجة والمحاكاة" },
                new Faculty_Electives { code = "IT 211", course_Name_en = "Computer Maintenance", hours = 3, prerequest_en = "-", course_Name_ar = "صيانة الحاسوب", prerequest_ar = "-" },
                new Faculty_Electives { code = "IT 241", course_Name_en = "Signals and Systems", hours = 3, prerequest_en = "Mathematics-2", course_Name_ar = "الإشارات والأنظمة", prerequest_ar = "رياضيات 2" },
                new Faculty_Electives { code = "ST 122", course_Name_en = "Probability and Statistics-2", hours = 3, prerequest_en = "Probability and Statistics-1", course_Name_ar = "احتمالات وإحصاء 2", prerequest_ar = "احتمالات وإحصاء 1" }
            );
        }
    }
}
