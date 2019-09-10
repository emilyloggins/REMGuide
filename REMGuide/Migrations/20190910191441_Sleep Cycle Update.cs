using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class SleepCycleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SleepCycle",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "884b4cbd-0074-44a2-abd2-fa00a4f4ca6e", "AQAAAAEAACcQAAAAEM1uDcWTp6aNqkqJ5ViCp/KR7jfay94g2nD3dria52cjRmMMQysR9WIUzEGrPcHbZg==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2019, 9, 10, 14, 14, 41, 127, DateTimeKind.Local).AddTicks(2644), null });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2019, 9, 10, 14, 14, 41, 133, DateTimeKind.Local).AddTicks(7453), null });

            migrationBuilder.CreateIndex(
                name: "IX_SleepCycle_UserId",
                table: "SleepCycle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SleepCycle_AspNetUsers_UserId",
                table: "SleepCycle",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SleepCycle_AspNetUsers_UserId",
                table: "SleepCycle");

            migrationBuilder.DropIndex(
                name: "IX_SleepCycle_UserId",
                table: "SleepCycle");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SleepCycle",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "820f9ef4-a70b-4573-9285-d3bc08f543b6", "AQAAAAEAACcQAAAAEC2wWWLamaqaCCoyy7aSOPyUUbcBhyRGQ0r98kuzaOnRyXl6qPADnC0YgUvv1TwejA==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2019, 9, 10, 14, 2, 2, 529, DateTimeKind.Local).AddTicks(6653), 1 });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2019, 9, 10, 14, 2, 2, 532, DateTimeKind.Local).AddTicks(3793), 1 });
        }
    }
}
