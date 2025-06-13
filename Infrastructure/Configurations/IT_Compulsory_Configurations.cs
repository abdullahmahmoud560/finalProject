using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class IT_Compulsory_Configurations : IEntityTypeConfiguration<IT_Compulsory>
    {
        public void Configure(EntityTypeBuilder<IT_Compulsory> builder)
        {
            builder.HasData(
                 new IT_Compulsory { code = "AI 310", course_Name_en = "Artificial Intelligence", course_Name_ar = "الذكاء الاصطناعي", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                 new IT_Compulsory { code = "IT 311", course_Name_en = "Computer Architecture", course_Name_ar = "هندسة الحاسوب", hours = 3, prerequest_en = "Logic Design", prerequest_ar = "تصميم المنطق" },
                 new IT_Compulsory { code = "IT 321", course_Name_en = "Communication Technology", course_Name_ar = "تقنية الاتصالات", hours = 3, prerequest_en = "Data Communication", prerequest_ar = "الاتصالات البيانات" },
                 new IT_Compulsory { code = "IT 322", course_Name_en = "Computers Network-2", course_Name_ar = "شبكات الحاسوب 2", hours = 3, prerequest_en = "Computer Networks-1", prerequest_ar = "شبكات الحاسوب 1" },
                 new IT_Compulsory { code = "IT 331", course_Name_en = "Computer Graphics-1", course_Name_ar = "الرسومات الحاسوبية 1", hours = 3, prerequest_en = "Programming-1", prerequest_ar = "البرمجة 1" },
                 new IT_Compulsory { code = "IT 341", course_Name_en = "Digital Signal Processing", course_Name_ar = "معالجة الإشارات الرقمية", hours = 3, prerequest_en = "Discrete Mathematics", prerequest_ar = "الرياضيات المتقطعة" },
                 new IT_Compulsory { code = "IT 342", course_Name_en = "Pattern Recognitions", course_Name_ar = "التعرف على الأنماط", hours = 3, prerequest_en = "-", prerequest_ar = "-" },
                 new IT_Compulsory { code = "IT 423", course_Name_en = "Information and Computer Networks Security", course_Name_ar = "أمن المعلومات وشبكات الحاسوب", hours = 3, prerequest_en = "Computer Networks-1", prerequest_ar = "شبكات الحاسوب 1" },
                 new IT_Compulsory { code = "IT 433", course_Name_en = "Multimedia", course_Name_ar = "الوسائط المتعددة", hours = 3, prerequest_en = "Programming-1", prerequest_ar = "البرمجة 1" },
                 new IT_Compulsory { code = "IT 441", course_Name_en = "Image Processing-1", course_Name_ar = "معالجة الصور 1", hours = 3, prerequest_en = "Signals and Systems", prerequest_ar = "الإشارات والأنظمة" },
                 new IT_Compulsory { code = "IT 444", course_Name_en = "Computer Vision", course_Name_ar = "الرؤية الحاسوبية", hours = 3, prerequest_en = "Algorithms", prerequest_ar = "الخوارزميات" },
                 new IT_Compulsory { code = "IT 498", course_Name_en = "Project", course_Name_ar = "مشروع", hours = 6, prerequest_en = "Computer Networks-1", prerequest_ar = "شبكات الحاسوب 1" }
             );
        }
    }

    public class IT_Electives_Configurations : IEntityTypeConfiguration<IT_Electives>
    {
        public void Configure(EntityTypeBuilder<IT_Electives> builder)
        {
            builder.HasData(
                 new IT_Electives { code = "CS 352", course_Name_en = "Software Engineering-2", course_Name_ar = "هندسة البرمجيات-2", hours = 3, prerequest_en = "Software Engineering-1", prerequest_ar = "هندسة البرمجيات-1" },
                 new IT_Electives { code = "IS 312", course_Name_en = "Database Systems-2", course_Name_ar = "أنظمة قواعد البيانات-2", hours = 3, prerequest_en = "Database Systems-1", prerequest_ar = "أنظمة قواعد البيانات-1" },
                 new IT_Electives { code = "IS 345", course_Name_en = "Internet Applications", course_Name_ar = "تطبيقات الإنترنت", hours = 3, prerequest_en = "Internet Technology", prerequest_ar = "تقنية الإنترنت" },
                 new IT_Electives { code = "IT 312", course_Name_en = "Microprocessors", course_Name_ar = "المعالجات الدقيقة", hours = 3, prerequest_en = "Logic Design", prerequest_ar = "تصميم المنطق" },
                 new IT_Electives { code = "IT 313", course_Name_en = "Computer Interfaces", course_Name_ar = "واجهات الحاسوب", hours = 3, prerequest_en = "Computer Architecture", prerequest_ar = "هندسة الحاسوب" },
                 new IT_Electives { code = "IT 332", course_Name_en = "Computer Graphics-2", course_Name_ar = "الرسومات الحاسوبية 2", hours = 3, prerequest_en = "Computer Graphics-1", prerequest_ar = "الرسومات الحاسوبية 1" },
                 new IT_Electives { code = "IT 411", course_Name_en = "Distributed and Parallel computer systems", course_Name_ar = "أنظمة الحاسوب الموزعة والمتوازية", hours = 3, prerequest_en = "Computer Architecture", prerequest_ar = "هندسة الحاسوب" },
                 new IT_Electives { code = "IT 412", course_Name_en = "Real Time Systems", course_Name_ar = "أنظمة الوقت الحقيقي", hours = 3, prerequest_en = "Computer Architecture", prerequest_ar = "هندسة الحاسوب" },
                 new IT_Electives { code = "IT 414", course_Name_en = "Embedded Systems", course_Name_ar = "الأنظمة المدمجة", hours = 3, prerequest_en = "Microprocessors", prerequest_ar = "المعالجات الدقيقة" },
                 new IT_Electives { code = "IT 415", course_Name_en = "Robotics", course_Name_ar = "الروبوتات", hours = 3, prerequest_en = "Discrete Mathematics", prerequest_ar = "الرياضيات المتقطعة" },
                 new IT_Electives { code = "IT 422", course_Name_en = "Wireless and Mobile Networks", course_Name_ar = "الشبكات اللاسلكية والمتحركة", hours = 3, prerequest_en = "Computers Network-2", prerequest_ar = "شبكات الحاسوب 2" },
                 new IT_Electives { code = "IT 425", course_Name_en = "Embedded Internet of things System", course_Name_ar = "الإنترنت المدمج للأشياء", hours = 3, prerequest_en = "Embedded Systems", prerequest_ar = "الأنظمة المدمجة" },
                 new IT_Electives { code = "IT 431", course_Name_en = "Virtual Reality", course_Name_ar = "الواقع الافتراضي", hours = 3, prerequest_en = "Computer Graphics-1", prerequest_ar = "الرسومات الحاسوبية 1" },
                 new IT_Electives { code = "IT 442", course_Name_en = "Image Processing-2", course_Name_ar = "معالجة الصور 2", hours = 3, prerequest_en = "Image Processing-1", prerequest_ar = "معالجة الصور 1" },
                 new IT_Electives { code = "IT 443", course_Name_en = "Speech Processing", course_Name_ar = "معالجة الكلام", hours = 3, prerequest_en = "Signals and Systems", prerequest_ar = "الإشارات والأنظمة" },
                 new IT_Electives { code = "IT 455", course_Name_en = "Image, audio and Video Processing", course_Name_ar = "معالجة الصور والصوت والفيديو", hours = 3, prerequest_en = "Speech Processing", prerequest_ar = "معالجة الكلام" },
                 new IT_Electives { code = "IT 456", course_Name_en = "3D Modeling and Animation", course_Name_ar = "النمذجة ثلاثية الأبعاد والرسوم المتحركة", hours = 3, prerequest_en = "Computer Graphics-1", prerequest_ar = "الرسومات الحاسوبية 1" },
                 new IT_Electives { code = "IT 457", course_Name_en = "Development Game", course_Name_ar = "تطوير الألعاب", hours = 3, prerequest_en = "Computer Graphics-1", prerequest_ar = "الرسومات الحاسوبية 1" },
                 new IT_Electives { code = "IT 496", course_Name_en = "Selected Topics in Information Technology", course_Name_ar = "مواضيع مختارة في تكنولوجيا المعلومات", hours = 3, prerequest_en = "-", prerequest_ar = "-" }
             );
        }
    }
}
