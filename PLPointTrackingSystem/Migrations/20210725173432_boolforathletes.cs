using Microsoft.EntityFrameworkCore.Migrations;

namespace PLPointTrackingSystem.Migrations
{
    public partial class boolforathletes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AthleteDataUploaded",
                table: "Meets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AthleteDataUploaded",
                table: "Meets");
        }
    }
}
