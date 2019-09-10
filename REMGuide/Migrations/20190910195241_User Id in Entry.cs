using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class UserIdinEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Entry",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1e2aa95-9688-4f58-97d6-7cac6bd53a02", "AQAAAAEAACcQAAAAEHrVO5BSHenIOlIHG5Gvph8wzUnbVShSw4HfugTp00FH5hg8sF2cOVkxTuFwn3rlGA==" });

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 10, 14, 52, 40, 498, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 14, 52, 40, 502, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.CreateIndex(
                name: "IX_Entry_UserId1",
                table: "Entry",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Entry_AspNetUsers_UserId1",
                table: "Entry",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entry_AspNetUsers_UserId1",
                table: "Entry");

            migrationBuilder.DropIndex(
                name: "IX_Entry_UserId1",
                table: "Entry");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Entry");

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
                values: new object[] { "884b4cbd-0074-44a2-abd2-fa00a4f4ca6e", "AQAAAAEAACcQAAAAEM1uDcWTp6aNqkqJ5ViCp/KR7jfay94g2nD3dria52cjRmMMQysR9WIUzEGrPcHbZg==" });

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
                value: new DateTime(2019, 9, 10, 14, 14, 41, 127, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 14, 14, 41, 133, DateTimeKind.Local).AddTicks(7453));

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
    }
}
