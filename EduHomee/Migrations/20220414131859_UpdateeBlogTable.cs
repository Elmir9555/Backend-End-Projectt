using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomee.Migrations
{
    public partial class UpdateeBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
