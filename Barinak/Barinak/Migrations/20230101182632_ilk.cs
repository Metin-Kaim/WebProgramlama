using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Migrations
{
    /// <inheritdoc />
    public partial class ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rehbers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RehberImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehbers", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rehberid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_Rehbers_Rehberid",
                        column: x => x.Rehberid,
                        principalTable: "Rehbers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hayvanlars_Turlers_Turid",
                        column: x => x.Turid,
                        principalTable: "Turlers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_Turid",
                table: "Hayvanlars",
                column: "Turid");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_Rehberid",
                table: "Yorumlars",
                column: "Rehberid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hayvanlars");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "Turlers");

            migrationBuilder.DropTable(
                name: "Rehbers");
        }
    }
}
