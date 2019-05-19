using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EsafyCapcitacion.Migrations
{
    public partial class _201905162300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseTest",
                columns: table => new
                {
                    CourseTestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTest", x => x.CourseTestId);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestion",
                columns: table => new
                {
                    TestQuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseTestId = table.Column<int>(nullable: false),
                    QuestionTitle = table.Column<string>(nullable: true),
                    HeadingText = table.Column<string>(nullable: true),
                    SubHeadingText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestion", x => x.TestQuestionId);
                    table.ForeignKey(
                        name: "FK_TestQuestion_CourseTest_CourseTestId",
                        column: x => x.CourseTestId,
                        principalTable: "CourseTest",
                        principalColumn: "CourseTestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOption",
                columns: table => new
                {
                    QuestionOptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestQuestionId = table.Column<int>(nullable: false),
                    MyProperty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOption", x => x.QuestionOptionId);
                    table.ForeignKey(
                        name: "FK_QuestionOption_TestQuestion_TestQuestionId",
                        column: x => x.TestQuestionId,
                        principalTable: "TestQuestion",
                        principalColumn: "TestQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOption_TestQuestionId",
                table: "QuestionOption",
                column: "TestQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_CourseTestId",
                table: "TestQuestion",
                column: "CourseTestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionOption");

            migrationBuilder.DropTable(
                name: "TestQuestion");

            migrationBuilder.DropTable(
                name: "CourseTest");
        }
    }
}
