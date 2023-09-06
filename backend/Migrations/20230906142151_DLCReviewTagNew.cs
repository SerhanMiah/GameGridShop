using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class DLCReviewTagNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 15, 21, 51, 473, DateTimeKind.Local).AddTicks(4707));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 15, 16, 2, 588, DateTimeKind.Local).AddTicks(1983));
        }
    }
}
