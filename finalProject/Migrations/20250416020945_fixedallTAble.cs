using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class fixedallTAble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_ssCode",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_ssId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_ssCode",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_ssId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "ssCode",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "ssId",
                table: "StudentSubjects");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectCode",
                table: "StudentSubjects",
                column: "SubjectCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectCode",
                table: "StudentSubjects",
                column: "SubjectCode",
                principalTable: "Subjects",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_students_StudentId",
                table: "StudentSubjects",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectCode",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_StudentId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_SubjectCode",
                table: "StudentSubjects");

            migrationBuilder.AddColumn<string>(
                name: "ssCode",
                table: "StudentSubjects",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ssId",
                table: "StudentSubjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_ssCode",
                table: "StudentSubjects",
                column: "ssCode");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_ssId",
                table: "StudentSubjects",
                column: "ssId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_ssCode",
                table: "StudentSubjects",
                column: "ssCode",
                principalTable: "Subjects",
                principalColumn: "code");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_students_ssId",
                table: "StudentSubjects",
                column: "ssId",
                principalTable: "students",
                principalColumn: "Id");
        }
    }
}
