using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class RemovedCheckBoxDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Entry",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.CreateIndex(
                name: "IX_Entry_UserId",
                table: "Entry",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entry_AspNetUsers_UserId",
                table: "Entry",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entry_AspNetUsers_UserId",
                table: "Entry");

            migrationBuilder.DropIndex(
                name: "IX_Entry_UserId",
                table: "Entry");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Entry",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c387874-643f-4fb4-8176-a421fe5424ba", "AQAAAAEAACcQAAAAEDK758cs41AeMFlB007c4WB+Wos2gywup/Wd5TXKQFNXbb/JeDMKLUQCdi+sJ+34HQ==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 10, 11, 22, 57, 199, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 11, 22, 57, 201, DateTimeKind.Local).AddTicks(7271));
        }
    }
}
