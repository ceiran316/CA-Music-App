using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TunesAPI.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class TunesThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tunes",
                columns: new[] { "Id", "Album", "AlbumCoverLink", "Artist", "BuyLink", "Duration", "Genre", "IrishChart", "Price", "Realsed", "Title" },
                values: new object[] { 1, "Thriller", "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png", "Michael Jackson", "https://www.amazon.com/Thriller-Michael-Jackson/dp/B00VSHH9GC/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552692547&sr=8-1", "5.58", "Pop", 1, 9.16, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
