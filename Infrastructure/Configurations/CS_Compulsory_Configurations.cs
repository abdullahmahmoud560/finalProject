using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class CS_Compulsory_Configurations : IEntityTypeConfiguration<CS_Compulsory>
    {
        public void Configure(EntityTypeBuilder<CS_Compulsory> builder)
        {
            builder.HasData(
                new CS_Compulsory { code = "AI 310", course_Name_en = "Artificial Intelligence", course_Name_ar = "الذكاء الاصطناعي", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                new CS_Compulsory { code = "AI 330", course_Name_en = "Machine Learning", course_Name_ar = "تعلم الآلة", hours = 3, prerequest_en = "Probability and Statistics-2", prerequest_ar = "الاحتمالات والإحصاء-2" },
                new CS_Compulsory { code = "CS 322", course_Name_en = "Computer Organization", course_Name_ar = "تنظيم الحاسوب", hours = 3, prerequest_en = "Logic Design", prerequest_ar = "تصميم المنطق" },
                new CS_Compulsory { code = "CS 342", course_Name_en = "Operating Systems-2", course_Name_ar = "أنظمة التشغيل-2", hours = 3, prerequest_en = "Operating Systems-1", prerequest_ar = "أنظمة التشغيل-1" },
                new CS_Compulsory { code = "CS 352", course_Name_en = "Software Engineering-2", course_Name_ar = "هندسة البرمجيات-2", hours = 3, prerequest_en = "Software Engineering-1", prerequest_ar = "هندسة البرمجيات-1" },
                new CS_Compulsory { code = "CS 405", course_Name_en = "Theory of Computation", course_Name_ar = "نظرية الحوسبة", hours = 3, prerequest_en = "Discrete Mathematics", prerequest_ar = "الرياضيات المتقطعة" },
                new CS_Compulsory { code = "CS 419", course_Name_en = "Compilers", course_Name_ar = "المترجمات", hours = 3, prerequest_en = "Data Structures", prerequest_ar = "هياكل البيانات" },
                new CS_Compulsory { code = "CS 460", course_Name_en = "Distributed systems and Cloud Computing", course_Name_ar = "الأنظمة الموزعة والحوسبة السحابية", hours = 3, prerequest_en = "Computer Networks-1", prerequest_ar = "شبكات الحاسوب-1" },
                new CS_Compulsory { code = "CS 471", course_Name_en = "Parallel Processing and high Performance Computing", course_Name_ar = "المعالجة المتوازية والحوسبة عالية الأداء", hours = 3, prerequest_en = "Operating Systems-1", prerequest_ar = "أنظمة التشغيل-1" },
                new CS_Compulsory { code = "CS 498", course_Name_en = "Project", course_Name_ar = "مشروع التخرج", hours = 6, prerequest_en = "Software Engineering-1", prerequest_ar = "هندسة البرمجيات-1" },
                new CS_Compulsory { code = "IT 331", course_Name_en = "Computer Graphics-1", course_Name_ar = "رسوميات الحاسوب-1", hours = 3, prerequest_en = "Programming-1", prerequest_ar = "برمجة-1" },
                new CS_Compulsory { code = "IT 423", course_Name_en = "Information and Computer Networks Security", course_Name_ar = "أمن المعلومات وشبكات الحاسوب", hours = 3, prerequest_en = "Computer Networks-1", prerequest_ar = "شبكات الحاسوب-1" }
            );
        }
    }

    public class CS_Electives_Configurations : IEntityTypeConfiguration<CS_Electives>
    {
        public void Configure(EntityTypeBuilder<CS_Electives> builder)
        {
            builder.HasData(
                new CS_Electives { code = "AI 335", course_Name_en = "Neural Networks & deep learning", course_Name_ar = "الشبكات العصبية والتعلم العميق", hours = 3, prerequest_en = "Machine Learning", prerequest_ar = "تعلم الآلة" },
                new CS_Electives { code = "AI 350", course_Name_en = "Data Visualization", course_Name_ar = "تصوير البيانات", hours = 3, prerequest_en = "Probability and Statistics-2", prerequest_ar = "الاحتمالات والإحصاء-2" },
                new CS_Electives { code = "AI 360", course_Name_en = "Natural Language Processing", course_Name_ar = "معالجة اللغات الطبيعية", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new CS_Electives { code = "AI 380", course_Name_en = "Human Computer Interaction", course_Name_ar = "التفاعل بين الإنسان والحاسوب", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new CS_Electives { code = "CS 410", course_Name_en = "Concepts of Programming Languages", course_Name_ar = "مفاهيم لغات البرمجة", hours = 3, prerequest_en = "Programming-1", prerequest_ar = "برمجة-1" },
                new CS_Electives { code = "CS 416", course_Name_en = "Advanced Algorithms", course_Name_ar = "الخوارزميات المتقدمة", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                new CS_Electives { code = "CS 480", course_Name_en = "Cryptography", course_Name_ar = "علم التشفير", hours = 3, prerequest_en = "Probability and Statistics-1", prerequest_ar = "الاحتمالات والإحصاء-1" },
                new CS_Electives { code = "CS 496", course_Name_en = "Selected Topics in Computer Science", course_Name_ar = "موضوعات مختارة في علوم الحاسوب", hours = 3, prerequest_en = "-", prerequest_ar = "-" },
                new CS_Electives { code = "IS 312", course_Name_en = "Database Systems-2", course_Name_ar = "نظم قواعد البيانات-2", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "نظم قواعد البيانات-1" },
                new CS_Electives { code = "IS 434", course_Name_en = "Quality Assurance of Information Systems and Programming", course_Name_ar = "ضمان الجودة في نظم المعلومات والبرمجة", hours = 3, prerequest_en = "System Analysis and Design-1", prerequest_ar = "تحليل وتصميم النظم-1" },
                new CS_Electives { code = "IT 312", course_Name_en = "Microprocessors", course_Name_ar = "المعالجات الدقيقة", hours = 3, prerequest_en = "Logic Design", prerequest_ar = "تصميم المنطق" },
                new CS_Electives { code = "IT 342", course_Name_en = "Pattern Recognitions", course_Name_ar = "تمييز الأنماط", hours = 3, prerequest_en = "-", prerequest_ar = "-" },
                new CS_Electives { code = "IT 414", course_Name_en = "Embedded Systems", course_Name_ar = "الأنظمة المضمنة", hours = 3, prerequest_en = "Microprocessors", prerequest_ar = "المعالجات الدقيقة" },
                new CS_Electives { code = "IT 433", course_Name_en = "Multimedia", course_Name_ar = "الوسائط المتعددة", hours = 3, prerequest_en = "Programming-1", prerequest_ar = "برمجة-1" },
                new CS_Electives { code = "IT 441", course_Name_en = "Image processing-1", course_Name_ar = "معالجة الصور-1", hours = 3, prerequest_en = "Signals and Systems", prerequest_ar = "الإشارات والأنظمة" },
                new CS_Electives { code = "IT 444", course_Name_en = "Computer Vision", course_Name_ar = "رؤية الحاسوب", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" }
            );
        }
    }
}
