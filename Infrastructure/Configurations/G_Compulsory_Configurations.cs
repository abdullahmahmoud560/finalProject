using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class G_Compulsory_Configurations : IEntityTypeConfiguration<General_Compulsory>
    {
        public void Configure(EntityTypeBuilder<General_Compulsory> builder)
        {
            builder.HasData(
                new General_Compulsory
                {
                    code = "HU 111",
                    course_Name_en = "English-1",
                    course_Name_ar = "اللغة الإنجليزية 1",
                    hours = 2,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Compulsory
                {
                    code = "HU 112",
                    course_Name_en = "English-2",
                    course_Name_ar = "اللغة الإنجليزية 2",
                    hours = 2,
                    prerequest_en = "English-1",
                    prerequest_ar = "اللغة الإنجليزية 1"
                },
                new General_Compulsory
                {
                    code = "HU 313",
                    course_Name_en = "Human Rights",
                    course_Name_ar = "حقوق الإنسان",
                    hours = 2,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                }
            );
        }
    }

    public class G_Elective_Configurations : IEntityTypeConfiguration<General_Electives>
    {
        public void Configure(EntityTypeBuilder<General_Electives> builder)
        {
            builder.HasData(
                new General_Electives
                {
                    code = "HU 121",
                    course_Name_en = "Fundamentals of Economics",
                    course_Name_ar = "أساسيات الاقتصاد",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Electives
                {
                    code = "HU 213",
                    course_Name_en = "English-3",
                    course_Name_ar = "اللغة الإنجليزية 3",
                    hours = 3,
                    prerequest_en = "English-2",
                    prerequest_ar = "اللغة الإنجليزية 2"
                },
                new General_Electives
                {
                    code = "HU 323",
                    course_Name_en = "Fundamentals of Accounting",
                    course_Name_ar = "أساسيات المحاسبة",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Electives
                {
                    code = "HU 331",
                    course_Name_en = "Communication & Negotiation Skills",
                    course_Name_ar = "مهارات الاتصال والتفاوض",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Electives
                {
                    code = "HU 332",
                    course_Name_en = "Creative Thinking",
                    course_Name_ar = "التفكير الإبداعي",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Electives
                {
                    code = "HU 333",
                    course_Name_en = "Mass Communication",
                    course_Name_ar = "الاتصال الجماهيري",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                },
                new General_Electives
                {
                    code = "HU 334",
                    course_Name_en = "Professional Ethics",
                    course_Name_ar = "الأخلاقيات المهنية",
                    hours = 3,
                    prerequest_en = "-",
                    prerequest_ar = "-"
                }
            );
        }
    }
}
