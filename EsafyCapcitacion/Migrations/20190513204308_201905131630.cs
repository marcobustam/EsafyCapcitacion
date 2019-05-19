using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EsafyCapcitacion.Migrations
{
    public partial class _201905131630 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CapacitationPlanId",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenceCode",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenceTitle",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VerticalId",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vertical",
                columns: table => new
                {
                    VerticalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VerticalName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vertical", x => x.VerticalId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CapacitationPlanId",
                table: "Course",
                column: "CapacitationPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CapacitationPlan_CapacitationPlanId",
                table: "Course",
                column: "CapacitationPlanId",
                principalTable: "CapacitationPlan",
                principalColumn: "CapacitationPlanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CapacitationPlan_CapacitationPlanId",
                table: "Course");

            migrationBuilder.DropTable(
                name: "Vertical");

            migrationBuilder.DropIndex(
                name: "IX_Course_CapacitationPlanId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CapacitationPlanId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SenceCode",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SenceTitle",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "VerticalId",
                table: "Course");
        }
    }
}
