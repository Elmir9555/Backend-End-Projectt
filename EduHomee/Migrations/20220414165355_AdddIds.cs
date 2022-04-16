using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomee.Migrations
{
    public partial class AdddIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseDetailId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseFeatureId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseDetailId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseFeatureId",
                table: "Courses");
        }
    }
}
