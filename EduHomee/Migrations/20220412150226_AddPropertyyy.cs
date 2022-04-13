using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomee.Migrations
{
    public partial class AddPropertyyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_SkillId_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_EventTeachers_EventId_TeacherId",
                table: "EventTeachers");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Sliders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_SkillId",
                table: "TeacherSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTeachers_EventId",
                table: "EventTeachers",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_SkillId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_EventTeachers_EventId",
                table: "EventTeachers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sliders");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_SkillId_TeacherId",
                table: "TeacherSkills",
                columns: new[] { "SkillId", "TeacherId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventTeachers_EventId_TeacherId",
                table: "EventTeachers",
                columns: new[] { "EventId", "TeacherId" },
                unique: true);
        }
    }
}
