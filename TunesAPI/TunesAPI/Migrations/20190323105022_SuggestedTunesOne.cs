using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace TunesAPI.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class SuggestedTunesOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuggestedTunes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedTunes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SuggestedTunes",
                columns: new[] { "Id", "Artist", "Count", "Genre", "Title" },
                values: new object[] { 1, "The Beatles", 1, "Rock", "Hey Jude" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuggestedTunes");
        }
    }
}
