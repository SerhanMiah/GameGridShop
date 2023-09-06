using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class DLCReviewTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DLC_Edition_EditionId",
                table: "DLC");

            migrationBuilder.DropForeignKey(
                name: "FK_DLC_Games_GameId",
                table: "DLC");

            migrationBuilder.DropForeignKey(
                name: "FK_Edition_Games_GameId",
                table: "Edition");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTag_Games_GameId",
                table: "GameTag");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTag_Tag_TagId",
                table: "GameTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Edition",
                table: "Edition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DLC",
                table: "DLC");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "GameTag",
                newName: "GameTags");

            migrationBuilder.RenameTable(
                name: "Edition",
                newName: "Editions");

            migrationBuilder.RenameTable(
                name: "DLC",
                newName: "DLCs");

            migrationBuilder.RenameIndex(
                name: "IX_GameTag_TagId",
                table: "GameTags",
                newName: "IX_GameTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Edition_GameId",
                table: "Editions",
                newName: "IX_Editions_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_DLC_GameId",
                table: "DLCs",
                newName: "IX_DLCs_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_DLC_EditionId",
                table: "DLCs",
                newName: "IX_DLCs_EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTags",
                table: "GameTags",
                columns: new[] { "GameId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                table: "Editions",
                column: "EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DLCs",
                table: "DLCs",
                column: "DLCId");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 15, 16, 2, 588, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.AddForeignKey(
                name: "FK_DLCs_Editions_EditionId",
                table: "DLCs",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "EditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DLCs_Games_GameId",
                table: "DLCs",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Games_GameId",
                table: "Editions",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTags_Tags_TagId",
                table: "GameTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DLCs_Editions_EditionId",
                table: "DLCs");

            migrationBuilder.DropForeignKey(
                name: "FK_DLCs_Games_GameId",
                table: "DLCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Games_GameId",
                table: "Editions");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTags_Tags_TagId",
                table: "GameTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTags",
                table: "GameTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DLCs",
                table: "DLCs");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "GameTags",
                newName: "GameTag");

            migrationBuilder.RenameTable(
                name: "Editions",
                newName: "Edition");

            migrationBuilder.RenameTable(
                name: "DLCs",
                newName: "DLC");

            migrationBuilder.RenameIndex(
                name: "IX_GameTags_TagId",
                table: "GameTag",
                newName: "IX_GameTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_GameId",
                table: "Edition",
                newName: "IX_Edition_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_DLCs_GameId",
                table: "DLC",
                newName: "IX_DLC_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_DLCs_EditionId",
                table: "DLC",
                newName: "IX_DLC_EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag",
                columns: new[] { "GameId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Edition",
                table: "Edition",
                column: "EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DLC",
                table: "DLC",
                column: "DLCId");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 14, 31, 19, 915, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AddForeignKey(
                name: "FK_DLC_Edition_EditionId",
                table: "DLC",
                column: "EditionId",
                principalTable: "Edition",
                principalColumn: "EditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DLC_Games_GameId",
                table: "DLC",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Edition_Games_GameId",
                table: "Edition",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTag_Games_GameId",
                table: "GameTag",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTag_Tag_TagId",
                table: "GameTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
