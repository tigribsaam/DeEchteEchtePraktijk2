using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ChangeArtURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Art",
                keyColumn: "ArtId",
                keyValue: 1,
                column: "ImageURL",
                value: "boldNbrash.jpg");

            migrationBuilder.UpdateData(
                table: "Art",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageURL",
                value: "WhistlersMother.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Art",
                keyColumn: "ArtId",
                keyValue: 1,
                column: "ImageURL",
                value: "http://art.ngfiles.com/images/425000/425133_catscr123_bold-and-brash.jpg");

            migrationBuilder.UpdateData(
                table: "Art",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://www.abc.net.au/news/image/7269490-3x2-700x467.jpg");
        }
    }
}
