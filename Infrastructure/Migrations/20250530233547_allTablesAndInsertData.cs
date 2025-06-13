using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class allTablesAndInsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AI Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AI Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AI Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AI Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CS Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CS Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Faculty Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Faculty Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "General Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "General Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IS Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IS Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IS Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IS Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IT Requirements_Compulsory",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IT Requirements_Compulsory", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IT Requirements_Electives",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    prerequest_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prerequest_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IT Requirements_Electives", x => x.code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: true),
                    gpa = table.Column<double>(type: "double", nullable: true),
                    department_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    department_ar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Name_en = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatHistories_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SubjectCode = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId");
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subjects_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subjects",
                        principalColumn: "SubjectCode");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Answer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    ChatHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_ChatHistories_ChatHistoryId",
                        column: x => x.ChatHistoryId,
                        principalTable: "ChatHistories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMessages_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AI Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 310", "الذكاء الاصطناعي", "Artificial Intelligence", 3, "الخوارزميات", "Algorithms" },
                    { "AI 320", "نظرية التحسين المحدب", "Convex Optimization Theory", 3, "الرياضيات-2", "Mathematics-2" },
                    { "AI 330", "تعلم الآلة", "Machine Learning", 3, "الاحتمالات والإحصاء-2", "Probability and Statistics-2" },
                    { "AI 335", "الشبكات العصبية والتعلم العميق", "Neural Networks & deeplearning", 3, "تعلم الآلة", "Machine Learning" },
                    { "AI 360", "معالجة اللغة الطبيعية", "Natural Language Processing", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 370", "تعلم الآلة المتقدم", "Advanced Machine Learning", 3, "تعلم الآلة", "Machine Learning" },
                    { "AI 420", "الخوارزميات التطورية", "Evolutionary Algorithm", 3, "نظرية التحسين المحدب", "Convex Optimization Theory" },
                    { "AI 430", "الذكاء الحسابي", "Computational Intelligence", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 460", "فهم اللغة الطبيعية", "Natural Language Understanding", 3, "معالجة اللغة الطبيعية", "Natural Language Processing" },
                    { "AI 498", "مشروع التخرج", "Project", 6, "هندسة البرمجيات-1", "Software Engineering-1" },
                    { "IS 365", "تقنيات البيانات الضخمة", "Big Data Technologies", 3, "أنظمة قواعد البيانات-1", "Database Systems-1" },
                    { "IT 441", "معالجة الصور-1", "Image processing-1", 3, "الإشارات والأنظمة", "Signals and Systems" }
                });

            migrationBuilder.InsertData(
                table: "AI Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 350", "تصوير البيانات", "Data Visualization", 3, "الاحتمالات والإحصاء-2", "Probability and Statistics-2" },
                    { "AI 380", "تفاعل الإنسان والحاسوب", "Human Computer Interaction", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 435", "معالجة اللغة المنطوقة", "Spoken language Processing", 3, "معالجة اللغة الطبيعية", "Natural Language Processing" },
                    { "AI 457", "تمثيل المعرفة", "Knowledge representation", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 490", "المعلوماتية الحيوية", "Bioinformatics", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 496", "مواضيع مختارة في الذكاء الاصطناعي", "Selected Topics in Artificial Intelligence", 3, "المستوى الرابع", "Level 4" },
                    { "CS 416", "الخوارزميات المتقدمة", "Advanced Algorithms", 3, "الخوارزميات", "Algorithms" },
                    { "CS 460", "الأنظمة الموزعة والحوسبة السحابية", "Distributed systems and Cloud Computing", 3, "شبكات الحاسوب-1", "Computers Network-1" },
                    { "CS 471", "المعالجة المتوازية والحوسبة عالية الأداء", "Parallel Processing and high Performance Computing", 3, "أنظمة التشغيل-1", "Operating Systems-1" },
                    { "CS 480", "التشفير", "Cryptography", 3, "الاحتمالات والإحصاء-1", "Probability and Statistics-1" },
                    { "IS 312", "أنظمة قواعد البيانات-2", "Database Systems-2", 3, "أنظمة قواعد البيانات-1", "Database Systems-1" },
                    { "IS 360", "مقدمة في علم البيانات", "Intorduction to Data Science", 3, "أنظمة قواعد البيانات-2", "Database Systems-2" },
                    { "IT 312", "المعالجات الدقيقة", "Microprocessors", 3, "تصميم المنطق", "Logic Design" },
                    { "IT 341", "معالجة الإشارات الرقمية", "Digital Signal Processing", 3, "الرياضيات المتقطعة", "Discrete Mathematics" },
                    { "IT 414", "الأنظمة المضمنة", "Embedded Systems", 3, "المعالجات الدقيقة", "Microprocessors" },
                    { "IT 415", "الروبوتات", "Robotics", 3, "الرياضيات المتقطعة", "Discrete Mathematics" },
                    { "IT 425", "أنظمة إنترنت الأشياء المضمنة", "Embedded Internet of things System", 3, "الأنظمة المضمنة", "Embedded Systems" },
                    { "IT 443", "معالجة الكلام", "Speech Processing", 3, "الإشارات والأنظمة", "Signals and Systems" },
                    { "IT 444", "رؤية الحاسوب", "Computer Vision", 3, "الخوارزميات", "Algorithms" }
                });

            migrationBuilder.InsertData(
                table: "CS Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 310", "الذكاء الاصطناعي", "Artificial Intelligence", 3, "الخوارزميات", "Algorithms" },
                    { "AI 330", "تعلم الآلة", "Machine Learning", 3, "الاحتمالات والإحصاء-2", "Probability and Statistics-2" },
                    { "CS 322", "تنظيم الحاسوب", "Computer Organization", 3, "تصميم المنطق", "Logic Design" },
                    { "CS 342", "أنظمة التشغيل-2", "Operating Systems-2", 3, "أنظمة التشغيل-1", "Operating Systems-1" },
                    { "CS 352", "هندسة البرمجيات-2", "Software Engineering-2", 3, "هندسة البرمجيات-1", "Software Engineering-1" },
                    { "CS 405", "نظرية الحوسبة", "Theory of Computation", 3, "الرياضيات المتقطعة", "Discrete Mathematics" },
                    { "CS 419", "المترجمات", "Compilers", 3, "هياكل البيانات", "Data Structures" },
                    { "CS 460", "الأنظمة الموزعة والحوسبة السحابية", "Distributed systems and Cloud Computing", 3, "شبكات الحاسوب-1", "Computer Networks-1" },
                    { "CS 471", "المعالجة المتوازية والحوسبة عالية الأداء", "Parallel Processing and high Performance Computing", 3, "أنظمة التشغيل-1", "Operating Systems-1" },
                    { "CS 498", "مشروع التخرج", "Project", 6, "هندسة البرمجيات-1", "Software Engineering-1" },
                    { "IT 331", "رسوميات الحاسوب-1", "Computer Graphics-1", 3, "برمجة-1", "Programming-1" },
                    { "IT 423", "أمن المعلومات وشبكات الحاسوب", "Information and Computer Networks Security", 3, "شبكات الحاسوب-1", "Computer Networks-1" }
                });

            migrationBuilder.InsertData(
                table: "CS Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 335", "الشبكات العصبية والتعلم العميق", "Neural Networks & deep learning", 3, "تعلم الآلة", "Machine Learning" },
                    { "AI 350", "تصوير البيانات", "Data Visualization", 3, "الاحتمالات والإحصاء-2", "Probability and Statistics-2" },
                    { "AI 360", "معالجة اللغات الطبيعية", "Natural Language Processing", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "AI 380", "التفاعل بين الإنسان والحاسوب", "Human Computer Interaction", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "CS 410", "مفاهيم لغات البرمجة", "Concepts of Programming Languages", 3, "برمجة-1", "Programming-1" },
                    { "CS 416", "الخوارزميات المتقدمة", "Advanced Algorithms", 3, "الخوارزميات", "Algorithms" },
                    { "CS 480", "علم التشفير", "Cryptography", 3, "الاحتمالات والإحصاء-1", "Probability and Statistics-1" },
                    { "CS 496", "موضوعات مختارة في علوم الحاسوب", "Selected Topics in Computer Science", 3, "-", "-" },
                    { "IS 312", "نظم قواعد البيانات-2", "Database Systems-2", 3, "نظم قواعد البيانات-1", "Database Systems-1" },
                    { "IS 434", "ضمان الجودة في نظم المعلومات والبرمجة", "Quality Assurance of Information Systems and Programming", 3, "تحليل وتصميم النظم-1", "System Analysis and Design-1" },
                    { "IT 312", "المعالجات الدقيقة", "Microprocessors", 3, "تصميم المنطق", "Logic Design" },
                    { "IT 342", "تمييز الأنماط", "Pattern Recognitions", 3, "-", "-" },
                    { "IT 414", "الأنظمة المضمنة", "Embedded Systems", 3, "المعالجات الدقيقة", "Microprocessors" },
                    { "IT 433", "الوسائط المتعددة", "Multimedia", 3, "برمجة-1", "Programming-1" },
                    { "IT 441", "معالجة الصور-1", "Image processing-1", 3, "الإشارات والأنظمة", "Signals and Systems" },
                    { "IT 444", "رؤية الحاسوب", "Computer Vision", 3, "الخوارزميات", "Algorithms" }
                });

            migrationBuilder.InsertData(
                table: "Faculty Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "CS 111", "مقدمة في الحاسوب", "Introduction to Computers", 3, "-", "-" },
                    { "CS 112", "برمجة 1", "Programming-1", 3, "مقدمة في الحاسوب", "Introduction to Computers" },
                    { "CS 213", "برمجة 2", "Programming-2", 3, "برمجة 1", "Programming-1" },
                    { "CS 214", "هياكل البيانات", "Data Structures", 3, "برمجة 1", "Programming-1" },
                    { "CS 221", "تصميم المنطق", "Logic Design", 3, "-", "-" },
                    { "CS 241", "أنظمة التشغيل 1", "Operating Systems-1", 3, "برمجة 1", "Programming-1" },
                    { "CS 251", "هندسة البرمجيات 1", "Software Engineering-1", 3, "برمجة 1", "Programming-1" },
                    { "CS 316", "الخوارزميات", "Algorithms", 3, "هياكل البيانات", "Data Structures" },
                    { "IS 211", "نظم قواعد البيانات 1", "Database Systems-1", 3, "-", "-" },
                    { "IS 231", "أساسيات نظم المعلومات", "Fundamentals of Information Systems", 3, "-", "-" },
                    { "IS 240", "بحوث العمليات", "Operations Research", 3, "-", "-" },
                    { "IS 351", "تحليل وتصميم النظم 1", "System Analysis and Design-1", 3, "أساسيات نظم المعلومات", "Fundamentals of Information Systems" },
                    { "IT 111", "إلكترونيات 1", "Electronics-1", 3, "-", "-" },
                    { "IT 221", "اتصالات البيانات", "Data Communication", 3, "احتمالات وإحصاء 1", "Probability and Statistics-1" },
                    { "IT 222", "شبكات الحاسوب 1", "Computer Networks-1", 3, "نظم قواعد البيانات 1", "Database Systems-1" },
                    { "IT 223", "تقنيات الإنترنت", "Internet Technology", 3, "-", "-" },
                    { "MA 111", "رياضيات 1", "Mathematics-1", 3, "-", "-" },
                    { "MA 112", "الرياضيات المتقطعة", "Discrete Mathematics", 3, "-", "-" },
                    { "MA 113", "رياضيات 2", "Mathematics–2", 3, "رياضيات 1", "Mathematics-1" },
                    { "PH 111", "الفيزياء", "Physics", 3, "-", "-" },
                    { "ST 121", "احتمالات وإحصاء 1", "Probability and Statistics-1", 3, "-", "-" }
                });

            migrationBuilder.InsertData(
                table: "Faculty Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "CS 313", "برمجة 3", "Programming-3", 3, "برمجة 2", "Programming-2" },
                    { "HU 122", "أساسيات الإدارة", "Fundamentals of Management", 3, "-", "-" },
                    { "IS 241", "النمذجة والمحاكاة", "Modeling and Simulation", 3, "-", "-" },
                    { "IS 321", "إدارة المشاريع", "Projects Management", 3, "بحوث العمليات", "Operations Research" },
                    { "IS 342", "لغات المحاكاة", "Simulation Languages", 3, "النمذجة والمحاكاة", "Modeling and Simulation" },
                    { "IT 211", "صيانة الحاسوب", "Computer Maintenance", 3, "-", "-" },
                    { "IT 241", "الإشارات والأنظمة", "Signals and Systems", 3, "رياضيات 2", "Mathematics-2" },
                    { "ST 122", "احتمالات وإحصاء 2", "Probability and Statistics-2", 3, "احتمالات وإحصاء 1", "Probability and Statistics-1" }
                });

            migrationBuilder.InsertData(
                table: "General Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "HU 111", "اللغة الإنجليزية 1", "English-1", 2, "-", "-" },
                    { "HU 112", "اللغة الإنجليزية 2", "English-2", 2, "اللغة الإنجليزية 1", "English-1" },
                    { "HU 313", "حقوق الإنسان", "Human Rights", 2, "-", "-" }
                });

            migrationBuilder.InsertData(
                table: "General Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "HU 121", "أساسيات الاقتصاد", "Fundamentals of Economics", 3, "-", "-" },
                    { "HU 213", "اللغة الإنجليزية 3", "English-3", 3, "اللغة الإنجليزية 2", "English-2" },
                    { "HU 323", "أساسيات المحاسبة", "Fundamentals of Accounting", 3, "-", "-" },
                    { "HU 331", "مهارات الاتصال والتفاوض", "Communication & Negotiation Skills", 3, "-", "-" },
                    { "HU 332", "التفكير الإبداعي", "Creative Thinking", 3, "-", "-" },
                    { "HU 333", "الاتصال الجماهيري", "Mass Communication", 3, "-", "-" },
                    { "HU 334", "الأخلاقيات المهنية", "Professional Ethics", 3, "-", "-" }
                });

            migrationBuilder.InsertData(
                table: "IS Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "IS 313", "تخزين واسترجاع البيانات", "Data Storage and Retrieval", 3, "أنظمة قواعد البيانات 1", "Database Systems-1" },
                    { "IS 333", "أنظمة معلومات الإدارة", "Management Information Systems", 3, "أساسيات نظم المعلومات", "Fundamentals of Information Systems" },
                    { "IS 345", "تطبيقات الإنترنت", "Internet Applications", 3, "تقنيات الإنترنت", "Internet Technology" },
                    { "IS 350", "ذكاء الأعمال وتحليل البيانات", "Business intelligence and data Analytical", 3, "الاحتمالات والإحصاء 2", "Probability and Statistics-2" },
                    { "IS 352", "تحليل وتصميم نظم المعلومات-2", "Analysis and Design of Information Systems-2", 3, "تحليل وتصميم النظم-1", "System Analysis and Design-1" },
                    { "IS 360", "مقدمة في علوم البيانات", "Introduction to Data Science", 3, "أنظمة قواعد البيانات 2", "Database Systems-2" },
                    { "IS 365", "تقنيات البيانات الضخمة", "Big Data Technologies", 3, "أنظمة قواعد البيانات 1", "Database Systems-1" },
                    { "IS 414", "أمن نظم المعلومات", "Information Systems Security", 3, "أنظمة قواعد البيانات 1", "Database Systems-1" },
                    { "IS 448", "إدارة قواعد المعرفة", "Knowledge base management", 3, "أنظمة قواعد البيانات 2", "Database Systems-2" },
                    { "IS 451", "نظم دعم القرار", "Decision Support Systems", 3, "أساسيات نظم المعلومات", "Fundamentals of Information Systems" },
                    { "IS 498", "مشروع", "Project", 6, "تحليل وتصميم النظم-1", "System Analysis and Design-1" },
                    { "IT 311", "أنظمة قواعد البيانات 2", "Database Systems-2", 3, "أنظمة قواعد البيانات 1", "Database Systems-1" }
                });

            migrationBuilder.InsertData(
                table: "IS Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 310", "الذكاء الاصطناعي", "Artificial Intelligence", 3, "الخوارزميات", "Algorithms" },
                    { "CS 352", "هندسة البرمجيات - 2", "Software Engineering -2", 3, "هندسة البرمجيات - 1", "Software Engineering -1" },
                    { "IS 334", "نظم معلومات المحاسبة", "Accounting Information Systems", 3, "أساسيات نظم المعلومات", "Fundamentals of Information Systems" },
                    { "IS 415", "قواعد البيانات الموجهة للكائنات", "Object Oriented Database", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 416", "قواعد البيانات الموزعة", "Distributed Database", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 421", "تنقيب البيانات", "Data Mining", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 422", "مستودعات البيانات", "Data Warehousing", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 434", "ضمان جودة نظم المعلومات والبرمجة", "Quality Assurance of Information Systems and Programming", 3, "تحليل وتصميم نظم المعلومات-2", "Analysis and Design of Information Systems-2" },
                    { "IS 435", "إدارة مراكز المعلومات", "Information Centers Management", 3, "-", "-" },
                    { "IS 441", "نظم المعلومات الذكية", "Intelligent Information Systems", 3, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { "IS 442", "التجارة الإلكترونية", "E-Commerce", 3, "تطبيقات الإنترنت", "Internet Applications" },
                    { "IS 443", "نظم المعلومات الجغرافية", "Geographical Information Systems", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 444", "نظم معلومات الوسائط المتعددة", "Multimedia Information Systems", 3, "أنظمة قواعد البيانات 1", "Database Systems – 1" },
                    { "IS 450", "اختبار البرمجيات والتكامل", "Software testing and integration", 3, "تحليل وتصميم نظم المعلومات-2", "Analysis and Design of Information Systems-2" },
                    { "IS 453", "منهجيات تطوير نظم المعلومات", "Information Systems Development Methodologies", 3, "تحليل وتصميم نظم المعلومات-2", "Analysis and Design of Information Systems-2" },
                    { "IS 455", "ضمان جودة واختبار البرمجيات", "Software Quality Assurance and Testing", 3, "أساسيات نظم المعلومات", "Fundamentals of Information Systems" },
                    { "IS 460", "مقدمة في التعلم العميق", "Introduction to deep learning", 3, "إدارة قواعد المعرفة", "Knowledge base management" },
                    { "IS 496", "مواضيع مختارة في نظم المعلومات", "Selected Topics in Information Systems", 3, "المستوى 4", "Level 4" },
                    { "IT 423", "أمن المعلومات وشبكات الحاسوب", "Information and Computer Networks Security", 3, "شبكات الحاسوب - 1", "Computers Network -1" }
                });

            migrationBuilder.InsertData(
                table: "IT Requirements_Compulsory",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "AI 310", "الذكاء الاصطناعي", "Artificial Intelligence", 3, "الخوارزميات", "Algorithms" },
                    { "IT 311", "هندسة الحاسوب", "Computer Architecture", 3, "تصميم المنطق", "Logic Design" },
                    { "IT 321", "تقنية الاتصالات", "Communication Technology", 3, "الاتصالات البيانات", "Data Communication" },
                    { "IT 322", "شبكات الحاسوب 2", "Computers Network-2", 3, "شبكات الحاسوب 1", "Computer Networks-1" },
                    { "IT 331", "الرسومات الحاسوبية 1", "Computer Graphics-1", 3, "البرمجة 1", "Programming-1" },
                    { "IT 341", "معالجة الإشارات الرقمية", "Digital Signal Processing", 3, "الرياضيات المتقطعة", "Discrete Mathematics" },
                    { "IT 342", "التعرف على الأنماط", "Pattern Recognitions", 3, "-", "-" },
                    { "IT 423", "أمن المعلومات وشبكات الحاسوب", "Information and Computer Networks Security", 3, "شبكات الحاسوب 1", "Computer Networks-1" },
                    { "IT 433", "الوسائط المتعددة", "Multimedia", 3, "البرمجة 1", "Programming-1" },
                    { "IT 441", "معالجة الصور 1", "Image Processing-1", 3, "الإشارات والأنظمة", "Signals and Systems" },
                    { "IT 444", "الرؤية الحاسوبية", "Computer Vision", 3, "الخوارزميات", "Algorithms" },
                    { "IT 498", "مشروع", "Project", 6, "شبكات الحاسوب 1", "Computer Networks-1" }
                });

            migrationBuilder.InsertData(
                table: "IT Requirements_Electives",
                columns: new[] { "code", "course_Name_ar", "course_Name_en", "hours", "prerequest_ar", "prerequest_en" },
                values: new object[,]
                {
                    { "CS 352", "هندسة البرمجيات-2", "Software Engineering-2", 3, "هندسة البرمجيات-1", "Software Engineering-1" },
                    { "IS 312", "أنظمة قواعد البيانات-2", "Database Systems-2", 3, "أنظمة قواعد البيانات-1", "Database Systems-1" },
                    { "IS 345", "تطبيقات الإنترنت", "Internet Applications", 3, "تقنية الإنترنت", "Internet Technology" },
                    { "IT 312", "المعالجات الدقيقة", "Microprocessors", 3, "تصميم المنطق", "Logic Design" },
                    { "IT 313", "واجهات الحاسوب", "Computer Interfaces", 3, "هندسة الحاسوب", "Computer Architecture" },
                    { "IT 332", "الرسومات الحاسوبية 2", "Computer Graphics-2", 3, "الرسومات الحاسوبية 1", "Computer Graphics-1" },
                    { "IT 411", "أنظمة الحاسوب الموزعة والمتوازية", "Distributed and Parallel computer systems", 3, "هندسة الحاسوب", "Computer Architecture" },
                    { "IT 412", "أنظمة الوقت الحقيقي", "Real Time Systems", 3, "هندسة الحاسوب", "Computer Architecture" },
                    { "IT 414", "الأنظمة المدمجة", "Embedded Systems", 3, "المعالجات الدقيقة", "Microprocessors" },
                    { "IT 415", "الروبوتات", "Robotics", 3, "الرياضيات المتقطعة", "Discrete Mathematics" },
                    { "IT 422", "الشبكات اللاسلكية والمتحركة", "Wireless and Mobile Networks", 3, "شبكات الحاسوب 2", "Computers Network-2" },
                    { "IT 425", "الإنترنت المدمج للأشياء", "Embedded Internet of things System", 3, "الأنظمة المدمجة", "Embedded Systems" },
                    { "IT 431", "الواقع الافتراضي", "Virtual Reality", 3, "الرسومات الحاسوبية 1", "Computer Graphics-1" },
                    { "IT 442", "معالجة الصور 2", "Image Processing-2", 3, "معالجة الصور 1", "Image Processing-1" },
                    { "IT 443", "معالجة الكلام", "Speech Processing", 3, "الإشارات والأنظمة", "Signals and Systems" },
                    { "IT 455", "معالجة الصور والصوت والفيديو", "Image, audio and Video Processing", 3, "معالجة الكلام", "Speech Processing" },
                    { "IT 456", "النمذجة ثلاثية الأبعاد والرسوم المتحركة", "3D Modeling and Animation", 3, "الرسومات الحاسوبية 1", "Computer Graphics-1" },
                    { "IT 457", "تطوير الألعاب", "Development Game", 3, "الرسومات الحاسوبية 1", "Computer Graphics-1" },
                    { "IT 496", "مواضيع مختارة في تكنولوجيا المعلومات", "Selected Topics in Information Technology", 3, "-", "-" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "course_Name_en", "hours" },
                values: new object[,]
                {
                    { "AI 310", "Artificial Intelligence", 3 },
                    { "AI 320", "Convex Optimization Theory", 3 },
                    { "AI 330", "Machine Learning", 3 },
                    { "AI 335", "Neural Networks & Deep Learning", 3 },
                    { "AI 350", "Data Visualization", 3 },
                    { "AI 360", "Natural Language Processing", 3 },
                    { "AI 370", "Advanced Machine Learning", 3 },
                    { "AI 380", "Human Computer Interaction", 3 },
                    { "AI 420", "Evolutionary Algorithm", 3 },
                    { "AI 430", "Computational Intelligence", 3 },
                    { "AI 435", "Spoken Language Processing", 3 },
                    { "AI 457", "Knowledge Representation", 3 },
                    { "AI 460", "Natural Language Understanding", 3 },
                    { "AI 490", "Bioinformatics", 3 },
                    { "AI 496", "Selected Topics in Artificial Intelligence", 3 },
                    { "AI 498", "Project", 6 },
                    { "CS 111", "Introduction to Computers", 3 },
                    { "CS 112", "Programming-1", 3 },
                    { "CS 213", "Programming-2", 3 },
                    { "CS 214", "Data Structures", 3 },
                    { "CS 221", "Logic Design", 3 },
                    { "CS 241", "Operating Systems-1", 3 },
                    { "CS 251", "Software Engineering-1", 3 },
                    { "CS 313", "Programming-3", 3 },
                    { "CS 316", "Algorithms", 3 },
                    { "CS 322", "Computer Organization", 3 },
                    { "CS 342", "Operating Systems-2", 3 },
                    { "CS 352", "Software Engineering-2", 3 },
                    { "CS 405", "Theory of Computation", 3 },
                    { "CS 410", "Concepts of Programming Languages", 3 },
                    { "CS 416", "Advanced Algorithms", 3 },
                    { "CS 419", "Compilers", 3 },
                    { "CS 460", "Distributed Systems and Cloud Computing", 3 },
                    { "CS 471", "Parallel Processing and High Performance Computing", 3 },
                    { "CS 480", "Cryptography", 3 },
                    { "CS 496", "Selected Topics in Computer Science", 3 },
                    { "CS 498", "Project", 6 },
                    { "HU 111", "English-1", 2 },
                    { "HU 112", "English-2", 2 },
                    { "HU 121", "Fundamentals of Economics", 3 },
                    { "HU 122", "Fundamentals of Management", 3 },
                    { "HU 213", "English-3", 3 },
                    { "HU 313", "Human Rights", 2 },
                    { "HU 323", "Fundamentals of Accounting", 3 },
                    { "HU 331", "Communication & Negotiation Skills", 3 },
                    { "HU 332", "Creative Thinking", 3 },
                    { "HU 333", "Mass Communication", 3 },
                    { "HU 334", "Professional Ethics", 3 },
                    { "IS 211", "Database Systems-1", 3 },
                    { "IS 231", "Fundamentals of Information Systems", 3 },
                    { "IS 240", "Operations Research", 3 },
                    { "IS 241", "Modeling and Simulation", 3 },
                    { "IS 312", "Database Systems-2", 3 },
                    { "IS 313", "Data Storage and Retrieval", 3 },
                    { "IS 321", "Projects Management", 3 },
                    { "IS 333", "Management Information Systems", 3 },
                    { "IS 334", "Accounting Information Systems", 3 },
                    { "IS 342", "Simulation Languages", 3 },
                    { "IS 345", "Internet Applications", 3 },
                    { "IS 350", "Business Intelligence and Data Analytical", 3 },
                    { "IS 351", "System Analysis and Design-1", 3 },
                    { "IS 352", "Analysis and Design of Information Systems-2", 3 },
                    { "IS 360", "Introduction to Data Science", 3 },
                    { "IS 365", "Big Data Technologies", 3 },
                    { "IS 414", "Information Systems Security", 3 },
                    { "IS 415", "Object Oriented Database", 3 },
                    { "IS 416", "Distributed Database", 3 },
                    { "IS 421", "Data Mining", 3 },
                    { "IS 422", "Data Warehousing", 3 },
                    { "IS 434", "Quality Assurance of Information Systems and Programming", 3 },
                    { "IS 435", "Information Centers Management", 3 },
                    { "IS 441", "Intelligent Information Systems", 3 },
                    { "IS 442", "E-Commerce", 3 },
                    { "IS 443", "Geographical Information Systems", 3 },
                    { "IS 444", "Multimedia Information Systems", 3 },
                    { "IS 448", "Knowledge base management", 3 },
                    { "IS 450", "Software Testing and Integration", 3 },
                    { "IS 451", "Decision Support Systems", 3 },
                    { "IS 453", "Information Systems Development Methodologies", 3 },
                    { "IS 455", "Software Quality Assurance and Testing", 3 },
                    { "IS 460", "Introduction to Deep Learning", 3 },
                    { "IS 496", "Selected Topics in Information Systems", 3 },
                    { "IS 498", "Project", 6 },
                    { "IT 111", "Electronics-1", 3 },
                    { "IT 211", "Computer Maintenance", 3 },
                    { "IT 221", "Data Communication", 3 },
                    { "IT 222", "Computer Networks-1", 3 },
                    { "IT 223", "Internet Technology", 3 },
                    { "IT 241", "Signals and Systems", 3 },
                    { "IT 311", "Computer Architecture", 3 },
                    { "IT 312", "Microprocessors", 3 },
                    { "IT 313", "Computer Interfaces", 3 },
                    { "IT 321", "Communication Technology", 3 },
                    { "IT 322", "Computers Network-2", 3 },
                    { "IT 331", "Computer Graphics-1", 3 },
                    { "IT 332", "Computer Graphics-2", 3 },
                    { "IT 341", "Digital Signal Processing", 3 },
                    { "IT 342", "Pattern Recognition", 3 },
                    { "IT 411", "Distributed and Parallel Computer Systems", 3 },
                    { "IT 412", "Real Time Systems", 3 },
                    { "IT 414", "Embedded Systems", 3 },
                    { "IT 415", "Robotics", 3 },
                    { "IT 422", "Wireless and Mobile Networks", 3 },
                    { "IT 423", "Information and Computer Networks Security", 3 },
                    { "IT 425", "Embedded Internet of Things System", 3 },
                    { "IT 431", "Virtual Reality", 3 },
                    { "IT 433", "Multimedia", 3 },
                    { "IT 441", "Image Processing-1", 3 },
                    { "IT 442", "Image Processing-2", 3 },
                    { "IT 443", "Speech Processing", 3 },
                    { "IT 444", "Computer Vision", 3 },
                    { "IT 455", "Image, Audio and Video Processing", 3 },
                    { "IT 456", "3D Modeling and Animation", 3 },
                    { "IT 457", "Game Development", 3 },
                    { "IT 496", "Selected Topics in Information Technology", 3 },
                    { "IT 498", "Project", 6 },
                    { "MA 111", "Mathematics-1", 3 },
                    { "MA 112", "Discrete Mathematics", 3 },
                    { "MA 113", "Mathematics-2", 3 },
                    { "PH 111", "Physics", 3 },
                    { "ST 121", "Probability and Statistics-1", 3 },
                    { "ST 122", "Probability and Statistics-2", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_StudentId",
                table: "ChatHistories",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatHistoryId",
                table: "ChatMessages",
                column: "ChatHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_StudentId",
                table: "ChatMessages",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentId",
                table: "StudentSubjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectCode",
                table: "StudentSubjects",
                column: "SubjectCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AI Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "AI Requirements_Electives");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "CS Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "CS Requirements_Electives");

            migrationBuilder.DropTable(
                name: "Faculty Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "Faculty Requirements_Electives");

            migrationBuilder.DropTable(
                name: "General Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "General Requirements_Electives");

            migrationBuilder.DropTable(
                name: "IS Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "IS Requirements_Electives");

            migrationBuilder.DropTable(
                name: "IT Requirements_Compulsory");

            migrationBuilder.DropTable(
                name: "IT Requirements_Electives");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "ChatHistories");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
