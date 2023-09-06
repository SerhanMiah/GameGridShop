using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class DemoImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "CoverImageUrl", "CreatedDate" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg", new DateTime(2023, 9, 6, 17, 4, 31, 33, DateTimeKind.Local).AddTicks(394) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://example.com/witcher_3_image1.jpg");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://example.com/witcher_3_image2.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "CoverImageUrl", "CreatedDate" },
                values: new object[] { "https://example.com/witcher_3_cover.jpg", new DateTime(2023, 9, 6, 15, 21, 51, 473, DateTimeKind.Local).AddTicks(4707) });
        }
    }
}
