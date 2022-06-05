using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AcesFirstPlayer", "AcesSecondPlayer", "DoubleFoultsFirstPlayer", "DoubleFoultsSecondPlayer", "FirstPlayerId", "FirstPlayerName", "FirstPlayerResult", "Name", "Round", "SecondPlayerId", "SecondPlayerName", "SecondPlayerResult", "TournamentId", "UnforcesErrorsFirstPlayer", "UnforcesErrorsSecondPlayer", "WinnersFirstPlayer", "WinnersSecondPlayer" },
                values: new object[] { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), 23, 11, 5, 9, new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), "Roger Federer", "6,7,3,7", "Men's Singles Court Philippe-Chatrier-Final", 6, new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael Nadal", "4,5,6,5", null, 35, 22, 48, 33 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "Loses", "MatchId", "TournamentsWins", "Wins" },
                values: new object[,]
                {
                    { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), "Roger", "Federer", 275, null, 0, 1251 },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael", "Nadal", 212, null, 0, 1051 },
                    { new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), "Grigor", "Dimitrov", 240, null, 0, 361 },
                    { new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), "Novak", "Djokovic", 203, null, 0, 1001 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "Name", "Surface" },
                values: new object[,]
                {
                    { new Guid("34405d3b-5831-41d8-8609-477a173f97e9"), "WIMBLEDON", 1 },
                    { new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c"), "US Open", 2 },
                    { new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e"), "Roland-Garros", 0 },
                    { new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125"), "Australian Open", 2 }
                });

            migrationBuilder.InsertData(
                table: "PlayerMatches",
                columns: new[] { "MatchId", "PlayerId" },
                values: new object[,]
                {
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53") },
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") }
                });

            migrationBuilder.InsertData(
                table: "PlayerTournament",
                columns: new[] { "PlayerId", "TournamentId" },
                values: new object[,]
                {
                    { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerMatches",
                keyColumns: new[] { "MatchId", "PlayerId" },
                keyValues: new object[] { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53") });

            migrationBuilder.DeleteData(
                table: "PlayerMatches",
                keyColumns: new[] { "MatchId", "PlayerId" },
                keyValues: new object[] { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") });

            migrationBuilder.DeleteData(
                table: "PlayerTournament",
                keyColumns: new[] { "PlayerId", "TournamentId" },
                keyValues: new object[] { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") });

            migrationBuilder.DeleteData(
                table: "PlayerTournament",
                keyColumns: new[] { "PlayerId", "TournamentId" },
                keyValues: new object[] { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") });

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("74c47f54-6175-4f57-af59-590ba981a51c"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("34405d3b-5831-41d8-8609-477a173f97e9"));
        }
    }
}
