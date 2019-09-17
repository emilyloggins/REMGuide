using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class AvgDisruptionDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e2ba90c-9b4b-4a0b-bfb4-83e11c993927", "AQAAAAEAACcQAAAAEJ+3LD+SQ9qmBG+5+IUsH+CMzVvap54nyhWkXs8P+/DN2xwkopjAVzsAoqD4vkolxw==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 17, 14, 16, 37, 480, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 17, 14, 16, 37, 488, DateTimeKind.Local).AddTicks(5836));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70ad9806-6f6b-4a5c-a47c-db1048b9655d", "AQAAAAEAACcQAAAAEKvKLInTVzrl4msEaTvBG7BTn6J3riL5iDxl1d2gSfVshe7gf3ue5WJQPZ/SZf0jVA==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 17, 14, 1, 12, 3, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 17, 14, 1, 12, 6, DateTimeKind.Local).AddTicks(3800));
        }
    }
}
