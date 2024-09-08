using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moive_finder.Migrations
{
    /// <inheritdoc />
    public partial class seedMovieTanle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "My Hero Academia");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "Documentary", "The wall" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "x-men");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "Action", "x-men" });
        }
    }
}
