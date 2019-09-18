using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class EntryDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c549880d-f4d2-4cfb-a411-845239dacccd", "AQAAAAEAACcQAAAAEKFK2yK7lYtcHrjqeWPGaYi0q25X6c/8OOUxoFu7cmvinYVVW4caCjWnHzXgCqsHow==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 18, 10, 28, 2, 522, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 18, 10, 28, 2, 522, DateTimeKind.Local).AddTicks(1363));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "051f5c24-cba3-4ef7-bfd5-0c8df2fb8cda", "AQAAAAEAACcQAAAAEGhC48c7wXY3+ZRDnPHr5XONErk7rSl/ZtYYwt6r7erlITdmNgJFnnJbwQqD29+iSQ==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 18, 10, 14, 48, 596, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 18, 10, 14, 48, 601, DateTimeKind.Local).AddTicks(1502));
        }
    }
}
