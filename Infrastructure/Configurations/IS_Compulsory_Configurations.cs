using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class IS_Compulsory_Configurations : IEntityTypeConfiguration<IS_Compulsory>
    {
        public void Configure(EntityTypeBuilder<IS_Compulsory> builder)
        {
            builder.HasData(
                new IS_Compulsory { code = "IS 313", course_Name_en = "Data Storage and Retrieval", course_Name_ar = "تخزين واسترجاع البيانات", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Compulsory { code = "IS 333", course_Name_en = "Management Information Systems", course_Name_ar = "أنظمة معلومات الإدارة", hours = 3, prerequest_en = "Fundamentals of Information Systems", prerequest_ar = "أساسيات نظم المعلومات" },
                new IS_Compulsory { code = "IS 345", course_Name_en = "Internet Applications", course_Name_ar = "تطبيقات الإنترنت", hours = 3, prerequest_en = "Internet Technology", prerequest_ar = "تقنيات الإنترنت" },
                new IS_Compulsory { code = "IS 350", course_Name_en = "Business intelligence and data Analytical", course_Name_ar = "ذكاء الأعمال وتحليل البيانات", hours = 3, prerequest_en = "Probability and Statistics-2", prerequest_ar = "الاحتمالات والإحصاء 2" },
                new IS_Compulsory { code = "IS 352", course_Name_en = "Analysis and Design of Information Systems-2", course_Name_ar = "تحليل وتصميم نظم المعلومات-2", hours = 3, prerequest_en = "System Analysis and Design-1", prerequest_ar = "تحليل وتصميم النظم-1" },
                new IS_Compulsory { code = "IS 360", course_Name_en = "Introduction to Data Science", course_Name_ar = "مقدمة في علوم البيانات", hours = 3, prerequest_en = "Database Systems-2", prerequest_ar = "أنظمة قواعد البيانات 2" },
                new IS_Compulsory { code = "IS 365", course_Name_en = "Big Data Technologies", course_Name_ar = "تقنيات البيانات الضخمة", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Compulsory { code = "IS 414", course_Name_en = "Information Systems Security", course_Name_ar = "أمن نظم المعلومات", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Compulsory { code = "IS 448", course_Name_en = "Knowledge base management", course_Name_ar = "إدارة قواعد المعرفة", hours = 3, prerequest_en = "Database Systems-2", prerequest_ar = "أنظمة قواعد البيانات 2" },
                new IS_Compulsory { code = "IS 451", course_Name_en = "Decision Support Systems", course_Name_ar = "نظم دعم القرار", hours = 3, prerequest_en = "Fundamentals of Information Systems", prerequest_ar = "أساسيات نظم المعلومات" },
                new IS_Compulsory { code = "IS 498", course_Name_en = "Project", course_Name_ar = "مشروع", hours = 6, prerequest_en = "System Analysis and Design-1", prerequest_ar = "تحليل وتصميم النظم-1" },
                new IS_Compulsory { code = "IT 311", course_Name_en = "Database Systems-2", course_Name_ar = "أنظمة قواعد البيانات 2", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات 1" }
            );
        }
    }

    public class IS_Electives_Configurations : IEntityTypeConfiguration<IS_Electives>
    {
        public void Configure(EntityTypeBuilder<IS_Electives> builder)
        {
            builder.HasData(
                new IS_Electives { code = "AI 310", course_Name_en = "Artificial Intelligence", course_Name_ar = "الذكاء الاصطناعي", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                new IS_Electives { code = "CS 352", course_Name_en = "Software Engineering -2", course_Name_ar = "هندسة البرمجيات - 2", hours = 3, prerequest_en = "Software Engineering -1", prerequest_ar = "هندسة البرمجيات - 1" },
                new IS_Electives { code = "IS 334", course_Name_en = "Accounting Information Systems", course_Name_ar = "نظم معلومات المحاسبة", hours = 3, prerequest_en = "Fundamentals of Information Systems", prerequest_ar = "أساسيات نظم المعلومات" },
                new IS_Electives { code = "IS 415", course_Name_en = "Object Oriented Database", course_Name_ar = "قواعد البيانات الموجهة للكائنات", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 416", course_Name_en = "Distributed Database", course_Name_ar = "قواعد البيانات الموزعة", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 421", course_Name_en = "Data Mining", course_Name_ar = "تنقيب البيانات", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 422", course_Name_en = "Data Warehousing", course_Name_ar = "مستودعات البيانات", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 434", course_Name_en = "Quality Assurance of Information Systems and Programming", course_Name_ar = "ضمان جودة نظم المعلومات والبرمجة", hours = 3, prerequest_en = "Analysis and Design of Information Systems-2", prerequest_ar = "تحليل وتصميم نظم المعلومات-2" },
                new IS_Electives { code = "IS 435", course_Name_en = "Information Centers Management", course_Name_ar = "إدارة مراكز المعلومات", hours = 3, prerequest_en = "-", prerequest_ar = "-" },
                new IS_Electives { code = "IS 441", course_Name_en = "Intelligent Information Systems", course_Name_ar = "نظم المعلومات الذكية", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new IS_Electives { code = "IS 442", course_Name_en = "E-Commerce", course_Name_ar = "التجارة الإلكترونية", hours = 3, prerequest_en = "Internet Applications", prerequest_ar = "تطبيقات الإنترنت" },
                new IS_Electives { code = "IS 443", course_Name_en = "Geographical Information Systems", course_Name_ar = "نظم المعلومات الجغرافية", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 444", course_Name_en = "Multimedia Information Systems", course_Name_ar = "نظم معلومات الوسائط المتعددة", hours = 3, prerequest_en = "Database Systems – 1", prerequest_ar = "أنظمة قواعد البيانات 1" },
                new IS_Electives { code = "IS 450", course_Name_en = "Software testing and integration", course_Name_ar = "اختبار البرمجيات والتكامل", hours = 3, prerequest_en = "Analysis and Design of Information Systems-2", prerequest_ar = "تحليل وتصميم نظم المعلومات-2" },
                new IS_Electives { code = "IS 453", course_Name_en = "Information Systems Development Methodologies", course_Name_ar = "منهجيات تطوير نظم المعلومات", hours = 3, prerequest_en = "Analysis and Design of Information Systems-2", prerequest_ar = "تحليل وتصميم نظم المعلومات-2" },
                new IS_Electives { code = "IS 455", course_Name_en = "Software Quality Assurance and Testing", course_Name_ar = "ضمان جودة واختبار البرمجيات", hours = 3, prerequest_en = "Fundamentals of Information Systems", prerequest_ar = "أساسيات نظم المعلومات" },
                new IS_Electives { code = "IS 460", course_Name_en = "Introduction to deep learning", course_Name_ar = "مقدمة في التعلم العميق", hours = 3, prerequest_en = "Knowledge base management", prerequest_ar = "إدارة قواعد المعرفة" },
                new IS_Electives { code = "IS 496", course_Name_en = "Selected Topics in Information Systems", course_Name_ar = "مواضيع مختارة في نظم المعلومات", hours = 3, prerequest_en = "Level 4", prerequest_ar = "المستوى 4" },
                new IS_Electives { code = "IT 423", course_Name_en = "Information and Computer Networks Security", course_Name_ar = "أمن المعلومات وشبكات الحاسوب", hours = 3, prerequest_en = "Computers Network -1", prerequest_ar = "شبكات الحاسوب - 1" }
            );
        }
    }
}
