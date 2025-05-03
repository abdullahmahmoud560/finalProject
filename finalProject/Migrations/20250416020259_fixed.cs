using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class @fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudentId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectCode",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_SubjectCode",
                table: "StudentSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Email",
                table: "students",
                newName: "IX_students_Email");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                table: "StudentSubjects",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

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

            migrationBuilder.AddColumn<int>(
                name: "StudentSubjectStudentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentSubjectSubjectCode",
                table: "students",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                table: "students",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_ssCode",
                table: "StudentSubjects",
                column: "ssCode");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_ssId",
                table: "StudentSubjects",
                column: "ssId");

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentSubjectStudentId_StudentSubjectSubjectCode",
                table: "students",
                columns: new[] { "StudentSubjectStudentId", "StudentSubjectSubjectCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_students_StudentSubjects_StudentSubjectStudentId_StudentSubj~",
                table: "students",
                columns: new[] { "StudentSubjectStudentId", "StudentSubjectSubjectCode" },
                principalTable: "StudentSubjects",
                principalColumns: new[] { "StudentId", "SubjectCode" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_StudentSubjects_StudentSubjectStudentId_StudentSubj~",
                table: "students");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_StudentSubjectStudentId_StudentSubjectSubjectCode",
                table: "students");

            migrationBuilder.DropColumn(
                name: "ssCode",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "ssId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "StudentSubjectStudentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentSubjectSubjectCode",
                table: "students");

            migrationBuilder.DropColumn(
                name: "SubjectCode",
                table: "students");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_students_Email",
                table: "Students",
                newName: "IX_Students_Email");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                table: "StudentSubjects",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectCode",
                table: "StudentSubjects",
                column: "SubjectCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudentId",
                table: "StudentSubjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectCode",
                table: "StudentSubjects",
                column: "SubjectCode",
                principalTable: "Subjects",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
