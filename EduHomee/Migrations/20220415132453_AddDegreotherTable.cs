using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomee.Migrations
{
    public partial class AddDegreotherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "skills");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
