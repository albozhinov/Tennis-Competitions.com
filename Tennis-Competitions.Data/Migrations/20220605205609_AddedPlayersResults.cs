using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class AddedPlayersResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Matches");

            migrationBuilder.AddColumn<string>(
                name: "FirstPlayerResult",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondPlayerResult",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPlayerResult",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "SecondPlayerResult",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
