using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class themes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0361a2a-aa30-4c80-904f-7ab8bf699675", "AQAAAAEAACcQAAAAECorVPS6Pu99dHRhDgS2DFPq7JowkgxG60IgQqGsLoTcFWILFu/HstZXSRsrEKvd2Q==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Entry",
                columns: new[] { "Id", "Date", "Description", "Title", "UserId" },
                values: new object[] { 3, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "They came from the sky. And when they came, they took everyone. The spaceship was cold and metal, but they had some dank chips and salsa tho", "Alien Invasion", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 19, 1, 10, 3, 549, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 19, 1, 10, 3, 549, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A dream about healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from.");

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThemeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThemeId",
                value: 8);

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[,]
                {
                    { 4, 2, 8 },
                    { 5, 2, 13 }
                });

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[] { 6, 3, 1 });

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[] { 7, 3, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ce035f-391a-4b70-bb92-c79c55534afb", "AQAAAAEAACcQAAAAEHmT+fHXh6PObgvMdmqWAWPMKQ4WMHYMzszvygoTkBSCgaTUqWLKae0UYmANEHeg/g==" });

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
                value: new DateTime(2019, 9, 18, 11, 25, 27, 189, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 18, 11, 25, 27, 189, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from.");

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThemeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThemeId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ThemeEntry",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThemeId",
                value: 5);
        }
    }
}
