using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Migrations
{
    /// <inheritdoc />
    public partial class hayvancins3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Cinslers_CinslerID",
                table: "Hayvanlars");

            migrationBuilder.DropTable(
                name: "Cinslers");

            migrationBuilder.RenameColumn(
                name: "CinslerID",
                table: "Hayvanlars",
                newName: "TurlersID");

            migrationBuilder.RenameIndex(
                name: "IX_Hayvanlars_CinslerID",
                table: "Hayvanlars",
                newName: "IX_Hayvanlars_TurlersID");

            migrationBuilder.CreateTable(
                name: "Turlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlers", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlersID",
                table: "Hayvanlars",
                column: "TurlersID",
                principalTable: "Turlers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Turlers_TurlersID",
                table: "Hayvanlars");

            migrationBuilder.DropTable(
                name: "Turlers");

            migrationBuilder.RenameColumn(
                name: "TurlersID",
                table: "Hayvanlars",
                newName: "CinslerID");

            migrationBuilder.RenameIndex(
                name: "IX_Hayvanlars_TurlersID",
                table: "Hayvanlars",
                newName: "IX_Hayvanlars_CinslerID");

            migrationBuilder.CreateTable(
                name: "Cinslers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinslers", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Cinslers_CinslerID",
                table: "Hayvanlars",
                column: "CinslerID",
                principalTable: "Cinslers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
