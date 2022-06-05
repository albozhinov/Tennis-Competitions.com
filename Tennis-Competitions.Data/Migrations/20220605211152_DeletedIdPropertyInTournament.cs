using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class DeletedIdPropertyInTournament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerTournament");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PlayerTournament",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
