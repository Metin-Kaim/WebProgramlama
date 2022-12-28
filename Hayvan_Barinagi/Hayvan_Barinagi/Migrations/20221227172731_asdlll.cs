using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagi.Migrations
{
    /// <inheritdoc />
    public partial class asdlll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_BakimRehberiId",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "BakimRehberiId",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Yorumlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BakimRehberiId",
                table: "Yorumlars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_BakimRehberiId",
                table: "Yorumlars",
                column: "BakimRehberiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars",
                column: "BakimRehberiId",
                principalTable: "BakimRehberis",
                principalColumn: "Id");
        }
    }
}
