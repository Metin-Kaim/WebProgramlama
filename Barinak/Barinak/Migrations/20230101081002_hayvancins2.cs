using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Migrations
{
    /// <inheritdoc />
    public partial class hayvancins2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cinsid",
                table: "Hayvanlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cinsid",
                table: "Hayvanlars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
