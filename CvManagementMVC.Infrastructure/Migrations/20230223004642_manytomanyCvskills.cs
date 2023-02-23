using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvManagementMVC.Infrastructure.Migrations
{
    public partial class manytomanyCvskills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Cvs_CvId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CvId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CvId",
                table: "Skills");

            migrationBuilder.CreateTable(
                name: "CvSkills",
                columns: table => new
                {
                    CvId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvSkills", x => new { x.CvId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CvSkills_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CvSkills_SkillId",
                table: "CvSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CvSkills");

            migrationBuilder.AddColumn<int>(
                name: "CvId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CvId",
                table: "Skills",
                column: "CvId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Cvs_CvId",
                table: "Skills",
                column: "CvId",
                principalTable: "Cvs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
