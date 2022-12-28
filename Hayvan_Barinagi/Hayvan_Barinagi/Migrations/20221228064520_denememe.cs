using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagi.Migrations
{
    /// <inheritdoc />
    public partial class denememe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars");

            migrationBuilder.AlterColumn<int>(
                name: "BakimRehberiId",
                table: "Yorumlars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars",
                column: "BakimRehberiId",
                principalTable: "BakimRehberis",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars");

            migrationBuilder.AlterColumn<int>(
                name: "BakimRehberiId",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_BakimRehberis_BakimRehberiId",
                table: "Yorumlars",
                column: "BakimRehberiId",
                principalTable: "BakimRehberis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
