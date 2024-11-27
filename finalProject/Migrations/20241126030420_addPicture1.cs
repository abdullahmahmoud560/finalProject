using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class addPicture1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Subjects");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePic",
                table: "Students",
                type: "longblob",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Students");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePic",
                table: "Subjects",
                type: "longblob",
                nullable: true);
        }
    }
}
