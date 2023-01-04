using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvManagementMVC.Infrastructure.Migrations
{
    public partial class UpdateForActiveFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Candidates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Candidates");
        }
    }
}
