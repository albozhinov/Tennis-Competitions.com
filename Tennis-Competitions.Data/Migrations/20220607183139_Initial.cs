using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstPlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Round = table.Column<int>(type: "int", nullable: false),
                    FirstPlayerResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPlayerResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcesFirstPlayer = table.Column<int>(type: "int", nullable: false),
                    AcesSecondPlayer = table.Column<int>(type: "int", nullable: false),
                    DoubleFoultsFirstPlayer = table.Column<int>(type: "int", nullable: false),
                    DoubleFoultsSecondPlayer = table.Column<int>(type: "int", nullable: false),
                    WinnersFirstPlayer = table.Column<int>(type: "int", nullable: false),
                    WinnersSecondPlayer = table.Column<int>(type: "int", nullable: false),
                    UnforcesErrorsFirstPlayer = table.Column<int>(type: "int", nullable: false),
                    UnforcesErrorsSecondPlayer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surface = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Loses = table.Column<int>(type: "int", nullable: false),
                    TournamentsWins = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TournamentMatches",
                columns: table => new
                {
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentMatches", x => new { x.MatchId, x.TournamentId });
                    table.ForeignKey(
                        name: "FK_TournamentMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentMatches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerMatches",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMatches", x => new { x.PlayerId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_PlayerMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerMatches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTournament",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTournament", x => new { x.PlayerId, x.TournamentId });
                    table.ForeignKey(
                        name: "FK_PlayerTournament_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTournament_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AcesFirstPlayer", "AcesSecondPlayer", "DoubleFoultsFirstPlayer", "DoubleFoultsSecondPlayer", "FirstPlayerId", "FirstPlayerName", "FirstPlayerResult", "Name", "Round", "SecondPlayerId", "SecondPlayerName", "SecondPlayerResult", "UnforcesErrorsFirstPlayer", "UnforcesErrorsSecondPlayer", "WinnersFirstPlayer", "WinnersSecondPlayer" },
                values: new object[,]
                {
                    { new Guid("1e418f5e-d2f0-42d3-9988-dbb81b958df2"), 16, 10, 0, 2, new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), "Roger Federer", "3,6,6,6", "Men's Singles AO-Semifinal", 3, new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), "Grigor Dimitrov", "6,4,2,2", 21, 56, 41, 51 },
                    { new Guid("291ff502-afde-4dd8-8d14-7cfa1681485d"), 5, 3, 4, 4, new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), "Novak Djokovic", "2,6,2,6", "Men's Singles Court Philippe-Chatrier-Quarterfinals", 4, new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael Nadal", "6,4,6,7", 53, 43, 48, 57 },
                    { new Guid("3403c603-0101-40d7-b4e7-3fbd88726220"), 16, 10, 0, 2, new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), "Roger Federer", "3,6,6,6", "Men's Singles US Open", 2, new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), "Grigor Dimitrov", "6,4,2,2", 21, 56, 41, 51 },
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), 23, 11, 5, 9, new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), "Roger Federer", "6,7,3,7", "Men's Singles Court Philippe-Chatrier-Final", 6, new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael Nadal", "4,5,6,5", 35, 22, 48, 33 },
                    { new Guid("8cd31c57-99d4-4d9d-aa73-c058d2ccf963"), 16, 10, 0, 2, new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael Nadal", "3,6,6,6", "Men's Singles Court Philippe-Chatrier-Semifinal", 5, new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), "Grigor Dimitrov", "6,4,2,2", 21, 56, 41, 51 },
                    { new Guid("cf80c189-5858-4135-8962-74444603bec5"), 5, 3, 4, 4, new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), "Novak Djokovic", "2,6,2,6", "Men's Singles US Open", 0, new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), "Rafael Nadal", "6,4,6,7", 53, 43, 48, 57 }
                });

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
                    { new Guid("3403c603-0101-40d7-b4e7-3fbd88726220"), new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53") },
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53") },
                    { new Guid("1e418f5e-d2f0-42d3-9988-dbb81b958df2"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") },
                    { new Guid("291ff502-afde-4dd8-8d14-7cfa1681485d"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") },
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") },
                    { new Guid("8cd31c57-99d4-4d9d-aa73-c058d2ccf963"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") },
                    { new Guid("cf80c189-5858-4135-8962-74444603bec5"), new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1") },
                    { new Guid("1e418f5e-d2f0-42d3-9988-dbb81b958df2"), new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a") },
                    { new Guid("3403c603-0101-40d7-b4e7-3fbd88726220"), new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a") },
                    { new Guid("8cd31c57-99d4-4d9d-aa73-c058d2ccf963"), new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a") },
                    { new Guid("291ff502-afde-4dd8-8d14-7cfa1681485d"), new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804") },
                    { new Guid("cf80c189-5858-4135-8962-74444603bec5"), new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804") }
                });

            migrationBuilder.InsertData(
                table: "PlayerTournament",
                columns: new[] { "PlayerId", "TournamentId" },
                values: new object[,]
                {
                    { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") },
                    { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"), new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125") },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c") },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"), new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125") },
                    { new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") },
                    { new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c") },
                    { new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"), new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125") },
                    { new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), new Guid("34405d3b-5831-41d8-8609-477a173f97e9") },
                    { new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c") },
                    { new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") }
                });

            migrationBuilder.InsertData(
                table: "TournamentMatches",
                columns: new[] { "MatchId", "TournamentId" },
                values: new object[,]
                {
                    { new Guid("1e418f5e-d2f0-42d3-9988-dbb81b958df2"), new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125") },
                    { new Guid("291ff502-afde-4dd8-8d14-7cfa1681485d"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("3403c603-0101-40d7-b4e7-3fbd88726220"), new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c") },
                    { new Guid("74c47f54-6175-4f57-af59-590ba981a51c"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("8cd31c57-99d4-4d9d-aa73-c058d2ccf963"), new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e") },
                    { new Guid("cf80c189-5858-4135-8962-74444603bec5"), new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatches_MatchId",
                table: "PlayerMatches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchId",
                table: "Players",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTournament_TournamentId",
                table: "PlayerTournament",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentMatches_TournamentId",
                table: "TournamentMatches",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PlayerMatches");

            migrationBuilder.DropTable(
                name: "PlayerTournament");

            migrationBuilder.DropTable(
                name: "TournamentMatches");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
