using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPI.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Review",
                newName: "ReviewId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MoviesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Review",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "Movies",
                newName: "Id");
        }
    }
}
