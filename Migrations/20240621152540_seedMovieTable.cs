using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moive_finder.Migrations
{
    /// <inheritdoc />
    public partial class seedMovieTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Name" },
                values: new object[] { 1, "Action", "x-men" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
