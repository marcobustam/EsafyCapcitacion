using Microsoft.EntityFrameworkCore.Migrations;

namespace EsafyCapcitacion.Migrations
{
    public partial class _201905181500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "QuestionOption",
                newName: "QuestionText");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectAns",
                table: "QuestionOption",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrectAns",
                table: "QuestionOption");

            migrationBuilder.RenameColumn(
                name: "QuestionText",
                table: "QuestionOption",
                newName: "MyProperty");
        }
    }
}
