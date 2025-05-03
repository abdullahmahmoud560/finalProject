using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class updateTales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Subjects",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Subjects",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "IT Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "IT Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "IS Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "IS Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "General Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "General Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "Faculty Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "Faculty Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "CS Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "CS Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "AI Requirements_Electives",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "AI Requirements_Compulsory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "grade",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "IT Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "IT Requirements_Compulsory");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "IS Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "IS Requirements_Compulsory");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "General Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "General Requirements_Compulsory");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Faculty Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Faculty Requirements_Compulsory");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "CS Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "CS Requirements_Compulsory");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "AI Requirements_Electives");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "AI Requirements_Compulsory");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Subjects",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "role",
                keyValue: null,
                column: "role",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "lastName",
                keyValue: null,
                column: "lastName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Token",
                keyValue: null,
                column: "Token",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Password",
                keyValue: null,
                column: "Password",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "FirstName",
                keyValue: null,
                column: "FirstName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IT Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "IS Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "General Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Faculty Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CS Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Electives",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Electives",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Electives",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Compulsory",
                keyColumn: "prerequest",
                keyValue: null,
                column: "prerequest",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prerequest",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Compulsory",
                keyColumn: "hours",
                keyValue: null,
                column: "hours",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AI Requirements_Compulsory",
                keyColumn: "course_Name",
                keyValue: null,
                column: "course_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "course_Name",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
