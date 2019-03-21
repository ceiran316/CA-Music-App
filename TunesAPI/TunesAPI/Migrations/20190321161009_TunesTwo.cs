using Microsoft.EntityFrameworkCore.Migrations;

namespace TunesAPI.Migrations
{
    public partial class TunesTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Tunes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Genre",
                table: "Tunes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }

}
