using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class SleepCycleMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "SleepCycle",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "SleepCycle");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adfdc86e-78f0-41df-9864-981b4cc9413f", "AQAAAAEAACcQAAAAEN3JPKziZbh/41SmlH4nU8IGru70ruthFWxHOg4PiVK48+QyMyfilejD0B0qeIbJGw==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 17, 9, 19, 53, 608, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 17, 9, 19, 53, 612, DateTimeKind.Local).AddTicks(6539));
        }
    }
}
