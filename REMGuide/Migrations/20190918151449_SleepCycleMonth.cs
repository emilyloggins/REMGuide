using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class SleepCycleMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "051f5c24-cba3-4ef7-bfd5-0c8df2fb8cda", "AQAAAAEAACcQAAAAEGhC48c7wXY3+ZRDnPHr5XONErk7rSl/ZtYYwt6r7erlITdmNgJFnnJbwQqD29+iSQ==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Month" },
                values: new object[] { new DateTime(2019, 9, 18, 10, 14, 48, 596, DateTimeKind.Local).AddTicks(5138), 9 });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Month" },
                values: new object[] { new DateTime(2019, 9, 18, 10, 14, 48, 601, DateTimeKind.Local).AddTicks(1502), 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fed3db0-f904-495d-b8ee-517a330c1a97", "AQAAAAEAACcQAAAAEN9gJ//mvyq8FbhUsgm1iwq/G1+G2jEr4lcE2SCIe7jpBGarQppzdlAvjdA4gepb8A==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Month" },
                values: new object[] { new DateTime(2019, 9, 18, 9, 57, 34, 274, DateTimeKind.Local).AddTicks(8309), 0 });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Month" },
                values: new object[] { new DateTime(2019, 9, 18, 9, 57, 34, 277, DateTimeKind.Local).AddTicks(2251), 0 });
        }
    }
}
