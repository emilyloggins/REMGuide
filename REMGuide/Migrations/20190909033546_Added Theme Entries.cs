using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class AddedThemeEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7d89d8c-eb2e-4ceb-91a5-4eec90d91543", "AQAAAAEAACcQAAAAEAWPCLe55r9BRyaPnOIO6QJc1YJMY7cv14+VJbXCyFHrp6yotAW+C51IMQnM4Otv9w==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 35, 45, 211, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 35, 45, 217, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 9 },
                    { 3, 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "384e6a5f-1531-45f4-a60f-34f86e0c2b47", "AQAAAAEAACcQAAAAED9Cd2UDZDl4DdzQR/u6FJ5PRUfTrrr7G8MmM2HEnyQl/XTtLdkMmfLrzkpRGgD0+Q==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 28, 20, 36, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 28, 20, 42, DateTimeKind.Local).AddTicks(641));
        }
    }
}
