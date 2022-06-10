using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    public partial class AddedImageURLProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                column: "ImageURL",
                value: "https://s.yimg.com/ny/api/res/1.2/inF.TxHhIpvjBALH3M4UxQ--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTM2MA--/https://s.yimg.com/os/creatr-uploaded-images/2022-05/fc07afd0-d986-11ec-add5-98233a9a2ecd");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                column: "ImageURL",
                value: "https://www.atptour.com/-/media/tennis/players/gladiator/2022/nadal-full-2022-may.png");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"),
                column: "ImageURL",
                value: "https://content.topcourt.com/uploads/player-images/thumb/20210324202739875800ZBMHF.jpg");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"),
                column: "ImageURL",
                value: "https://www.atptour.com/-/media/alias/player-headshot/D643");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("34405d3b-5831-41d8-8609-477a173f97e9"),
                column: "ImageURL",
                value: "https://i.pinimg.com/originals/6f/82/76/6f8276a2cf7af9be2ad0c875bdacb944.png");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c"),
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Usopen-header-logo.svg/2560px-Usopen-header-logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e"),
                column: "ImageURL",
                value: "https://images.prismic.io/fft-rg-site%2F95765448-c7fa-428b-b565-8368dba90b17_logo.svg?auto=compress,format");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125"),
                column: "ImageURL",
                value: "https://ausopen.com/sites/default/files/styles/medium/public/ao_blue_1.png?itok=Yw-P35xE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Players");
        }
    }
}
