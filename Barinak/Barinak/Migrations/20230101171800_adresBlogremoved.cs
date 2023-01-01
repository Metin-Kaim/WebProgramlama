using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Migrations
{
    /// <inheritdoc />
    public partial class adresBlogremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "AdresBlogs");

            migrationBuilder.DropColumn(
                name: "AdresAcik",
                table: "AdresBlogs");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "AdresBlogs");

            migrationBuilder.DropColumn(
                name: "Konum",
                table: "AdresBlogs");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "AdresBlogs");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "AdresBlogs");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AdresBlogs",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "AdresBlogs",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdresAcik",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Konum",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "AdresBlogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
