using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Migrations
{
    /// <inheritdoc />
    public partial class hayvancins7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlersID",
                table: "Hayvanlars");

            migrationBuilder.DropIndex(
                name: "IX_Hayvanlars_TurlersID",
                table: "Hayvanlars");

            migrationBuilder.DropColumn(
                name: "TurlersID",
                table: "Hayvanlars");

            migrationBuilder.AddColumn<int>(
                name: "TurlerID",
                table: "Hayvanlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_TurlerID",
                table: "Hayvanlars",
                column: "TurlerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlerID",
                table: "Hayvanlars",
                column: "TurlerID",
                principalTable: "Turlers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlerID",
                table: "Hayvanlars");

            migrationBuilder.DropIndex(
                name: "IX_Hayvanlars_TurlerID",
                table: "Hayvanlars");

            migrationBuilder.DropColumn(
                name: "TurlerID",
                table: "Hayvanlars");

            migrationBuilder.AddColumn<int>(
                name: "TurlersID",
                table: "Hayvanlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_TurlersID",
                table: "Hayvanlars",
                column: "TurlersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlersID",
                table: "Hayvanlars",
                column: "TurlersID",
                principalTable: "Turlers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
