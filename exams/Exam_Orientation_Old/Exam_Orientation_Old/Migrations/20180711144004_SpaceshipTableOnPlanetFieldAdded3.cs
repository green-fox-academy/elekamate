using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam_Orientation_Old.Migrations
{
    public partial class SpaceshipTableOnPlanetFieldAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OnPlanet",
                table: "SpaceShip",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnPlanet",
                table: "SpaceShip");
        }
    }
}
