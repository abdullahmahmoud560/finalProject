using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class updateTale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "grade",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Students");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Subjects",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePic",
                table: "Students",
                type: "longblob",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IT Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IT Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IS Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "IS Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "General Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "General Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Faculty Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Faculty Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "CS Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "CS Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "AI Requirements_Electives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "AI Requirements_Compulsory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
