using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class AI_Compulsory_Configurations : IEntityTypeConfiguration<AI_Compulsory>
    {
        public void Configure(EntityTypeBuilder<AI_Compulsory> builder)
        {
            builder.HasData(
                new AI_Compulsory { code = "AI 310", course_Name_en = "Artificial Intelligence", course_Name_ar = "الذكاء الاصطناعي", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                new AI_Compulsory { code = "AI 320", course_Name_en = "Convex Optimization Theory", course_Name_ar = "نظرية التحسين المحدب", hours = 3, prerequest_en = "Mathematics-2", prerequest_ar = "الرياضيات-2" },
                new AI_Compulsory { code = "AI 330", course_Name_en = "Machine Learning", course_Name_ar = "تعلم الآلة", hours = 3, prerequest_en = "Probability and Statistics-2", prerequest_ar = "الاحتمالات والإحصاء-2" },
                new AI_Compulsory { code = "AI 335", course_Name_en = "Neural Networks & deeplearning", course_Name_ar = "الشبكات العصبية والتعلم العميق", hours = 3, prerequest_en = "Machine Learning", prerequest_ar = "تعلم الآلة" },
                new AI_Compulsory { code = "AI 360", course_Name_en = "Natural Language Processing", course_Name_ar = "معالجة اللغة الطبيعية", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new AI_Compulsory { code = "AI 370", course_Name_en = "Advanced Machine Learning", course_Name_ar = "تعلم الآلة المتقدم", hours = 3, prerequest_en = "Machine Learning", prerequest_ar = "تعلم الآلة" },
                new AI_Compulsory { code = "AI 420", course_Name_en = "Evolutionary Algorithm", course_Name_ar = "الخوارزميات التطورية", hours = 3, prerequest_en = "Convex Optimization Theory", prerequest_ar = "نظرية التحسين المحدب" },
                new AI_Compulsory { code = "AI 430", course_Name_en = "Computational Intelligence", course_Name_ar = "الذكاء الحسابي", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new AI_Compulsory { code = "AI 460", course_Name_en = "Natural Language Understanding", course_Name_ar = "فهم اللغة الطبيعية", hours = 3, prerequest_en = "Natural Language Processing", prerequest_ar = "معالجة اللغة الطبيعية" },
                new AI_Compulsory { code = "AI 498", course_Name_en = "Project", course_Name_ar = "مشروع التخرج", hours = 6, prerequest_en = "Software Engineering-1", prerequest_ar = "هندسة البرمجيات-1" },
                new AI_Compulsory { code = "IS 365", course_Name_en = "Big Data Technologies", course_Name_ar = "تقنيات البيانات الضخمة", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات-1" },
                new AI_Compulsory { code = "IT 441", course_Name_en = "Image processing-1", course_Name_ar = "معالجة الصور-1", hours = 3, prerequest_en = "Signals and Systems", prerequest_ar = "الإشارات والأنظمة" }
            );
        }
    }

    public class AI_Electives_Configurations : IEntityTypeConfiguration<AI_Electives>
    {
        public void Configure(EntityTypeBuilder<AI_Electives> builder)
        {
            builder.HasData(
                new AI_Electives { code = "AI 350", course_Name_en = "Data Visualization", course_Name_ar = "تصوير البيانات", hours = 3, prerequest_en = "Probability and Statistics-2", prerequest_ar = "الاحتمالات والإحصاء-2" },
                new AI_Electives { code = "AI 380", course_Name_en = "Human Computer Interaction", course_Name_ar = "تفاعل الإنسان والحاسوب", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new AI_Electives { code = "AI 435", course_Name_en = "Spoken language Processing", course_Name_ar = "معالجة اللغة المنطوقة", hours = 3, prerequest_en = "Natural Language Processing", prerequest_ar = "معالجة اللغة الطبيعية" },
                new AI_Electives { code = "AI 457", course_Name_en = "Knowledge representation", course_Name_ar = "تمثيل المعرفة", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new AI_Electives { code = "AI 490", course_Name_en = "Bioinformatics", course_Name_ar = "المعلوماتية الحيوية", hours = 3, prerequest_en = "Artificial Intelligence", prerequest_ar = "الذكاء الاصطناعي" },
                new AI_Electives { code = "AI 496", course_Name_en = "Selected Topics in Artificial Intelligence", course_Name_ar = "مواضيع مختارة في الذكاء الاصطناعي", hours = 3, prerequest_en = "Level 4", prerequest_ar = "المستوى الرابع" },
                new AI_Electives { code = "CS 416", course_Name_en = "Advanced Algorithms", course_Name_ar = "الخوارزميات المتقدمة", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                new AI_Electives { code = "CS 460", course_Name_en = "Distributed systems and Cloud Computing", course_Name_ar = "الأنظمة الموزعة والحوسبة السحابية", hours = 3, prerequest_en = "Computers Network-1", prerequest_ar = "شبكات الحاسوب-1" },
                new AI_Electives { code = "CS 471", course_Name_en = "Parallel Processing and high Performance Computing", course_Name_ar = "المعالجة المتوازية والحوسبة عالية الأداء", hours = 3, prerequest_en = "Operating Systems-1", prerequest_ar = "أنظمة التشغيل-1" },
                new AI_Electives { code = "CS 480", course_Name_en = "Cryptography", course_Name_ar = "التشفير", hours = 3, prerequest_en = "Probability and Statistics-1", prerequest_ar = "الاحتمالات والإحصاء-1" },
                new AI_Electives { code = "IS 312", course_Name_en = "Database Systems-2", course_Name_ar = "أنظمة قواعد البيانات-2", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات-1" },
                new AI_Electives { code = "IS 360", course_Name_en = "Intorduction to Data Science", course_Name_ar = "مقدمة في علم البيانات", hours = 3, prerequest_en = "Database Systems-2", prerequest_ar = "أنظمة قواعد البيانات-2" },
                new AI_Electives { code = "IT 312", course_Name_en = "Microprocessors", course_Name_ar = "المعالجات الدقيقة", hours = 3, prerequest_en = "Logic Design", prerequest_ar = "تصميم المنطق" },
                new AI_Electives { code = "IT 341", course_Name_en = "Digital Signal Processing", course_Name_ar = "معالجة الإشارات الرقمية", hours = 3, prerequest_en = "Discrete Mathematics", prerequest_ar = "الرياضيات المتقطعة" },
                new AI_Electives { code = "IT 414", course_Name_en = "Embedded Systems", course_Name_ar = "الأنظمة المضمنة", hours = 3, prerequest_en = "Microprocessors", prerequest_ar = "المعالجات الدقيقة" },
                new AI_Electives { code = "IT 415", course_Name_en = "Robotics", course_Name_ar = "الروبوتات", hours = 3, prerequest_en = "Discrete Mathematics", prerequest_ar = "الرياضيات المتقطعة" },
                new AI_Electives { code = "IT 425", course_Name_en = "Embedded Internet of things System", course_Name_ar = "أنظمة إنترنت الأشياء المضمنة", hours = 3, prerequest_en = "Embedded Systems", prerequest_ar = "الأنظمة المضمنة" },
                new AI_Electives { code = "IT 443", course_Name_en = "Speech Processing", course_Name_ar = "معالجة الكلام", hours = 3, prerequest_en = "Signals and Systems", prerequest_ar = "الإشارات والأنظمة" },
                new AI_Electives { code = "IT 444", course_Name_en = "Computer Vision", course_Name_ar = "رؤية الحاسوب", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" }
            );
        }
    }
}
