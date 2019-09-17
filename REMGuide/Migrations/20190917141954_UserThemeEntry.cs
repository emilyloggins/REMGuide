using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class UserThemeEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "852aff99-9089-44d1-acac-06b6cd1b07bb", "AQAAAAEAACcQAAAAEOclCuLXjZCrvZP+S82K8UUcOvWMJ2m5s2a4mQLsUr10XgtvOBREhhqws1SAWGUimg==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 16, 11, 42, 39, 953, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 16, 11, 42, 39, 956, DateTimeKind.Local).AddTicks(7431));
        }
    }
}
