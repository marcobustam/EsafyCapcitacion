using Microsoft.EntityFrameworkCore.Migrations;

namespace EsafyCapcitacion.Migrations
{
    public partial class _201905162315 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseTestName",
                table: "CourseTest",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseTestName",
                table: "CourseTest");
        }
    }
}
