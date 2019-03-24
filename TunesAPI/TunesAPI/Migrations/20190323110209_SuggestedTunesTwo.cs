using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace TunesAPI.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class SuggestedTunesTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 3);

            migrationBuilder.InsertData(
                table: "SuggestedTunes",
                columns: new[] { "Id", "Artist", "Count", "Genre", "Title" },
                values: new object[,]
                {
                    { 2, "Black Eyed Peas", 2, "Pop", "Where is the Love" },
                    { 3, "AC/DC", 4, "Metal", "Thunderstruck" },
                    { 4, "Jay-Z", 2, "Hip-Hop", "99 Problems" },
                    { 5, "Nathan Carter", 1, "Country", "Wagon Wheel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "SuggestedTunes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);
        }
    }
}
