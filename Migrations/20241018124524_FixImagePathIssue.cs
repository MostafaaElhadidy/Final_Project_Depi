using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammingTutor.Migrations
{
    /// <inheritdoc />
    public partial class FixImagePathIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Tutorials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BadgeImagePath",
                table: "Achievements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Tutorials");

            migrationBuilder.DropColumn(
                name: "BadgeImagePath",
                table: "Achievements");
        }
    }
}
