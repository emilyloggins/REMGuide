using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class FixedASPUserconflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "820f9ef4-a70b-4573-9285-d3bc08f543b6", "AQAAAAEAACcQAAAAEC2wWWLamaqaCCoyy7aSOPyUUbcBhyRGQ0r98kuzaOnRyXl6qPADnC0YgUvv1TwejA==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 10, 14, 2, 2, 529, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 14, 2, 2, 532, DateTimeKind.Local).AddTicks(3793));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abd962bc-e14a-468b-bd9d-8b6e7ef31a2e", "AQAAAAEAACcQAAAAECAPgSpAmHJxy9VcOZ36Wxaonj7aWbNiy59gT4FMUdNJhSsVpmO0g32XHMmbBhsTnA==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 10, 13, 59, 43, 747, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 13, 59, 43, 750, DateTimeKind.Local).AddTicks(7996));
        }
    }
}
