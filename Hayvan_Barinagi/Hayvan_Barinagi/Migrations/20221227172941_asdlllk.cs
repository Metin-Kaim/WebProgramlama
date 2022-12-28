﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagi.Migrations
{
    /// <inheritdoc />
    public partial class asdlllk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BakimRehberiId",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
