using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class FixedJSONBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                column: "TournamentsWins",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                column: "TournamentsWins",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"),
                column: "TournamentsWins",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"),
                column: "TournamentsWins",
                value: 87);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                column: "TournamentsWins",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                column: "TournamentsWins",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"),
                column: "TournamentsWins",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"),
                column: "TournamentsWins",
                value: 0);
        }
    }
}
