using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class ThemeEntryViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThemeEntryViewModelId",
                table: "Theme",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThemeEntryViewModelId",
                table: "Entry",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ThemeEntryViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeEntryViewModel", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c861d829-bb32-4f36-b4ec-bb2491611097", "AQAAAAEAACcQAAAAEB1WOsPTTvvpSSGmvTE2kaE9cbypsceQnDrKMhYNAARiMIFyi242VLI6WuTnt4mzaQ==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 8, 21, 7, 26, 676, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 8, 21, 7, 26, 680, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.CreateIndex(
                name: "IX_Theme_ThemeEntryViewModelId",
                table: "Theme",
                column: "ThemeEntryViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_ThemeEntryViewModelId",
                table: "Entry",
                column: "ThemeEntryViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entry_ThemeEntryViewModel_ThemeEntryViewModelId",
                table: "Entry",
                column: "ThemeEntryViewModelId",
                principalTable: "ThemeEntryViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Theme_ThemeEntryViewModel_ThemeEntryViewModelId",
                table: "Theme",
                column: "ThemeEntryViewModelId",
                principalTable: "ThemeEntryViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entry_ThemeEntryViewModel_ThemeEntryViewModelId",
                table: "Entry");

            migrationBuilder.DropForeignKey(
                name: "FK_Theme_ThemeEntryViewModel_ThemeEntryViewModelId",
                table: "Theme");

            migrationBuilder.DropTable(
                name: "ThemeEntryViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Theme_ThemeEntryViewModelId",
                table: "Theme");

            migrationBuilder.DropIndex(
                name: "IX_Entry_ThemeEntryViewModelId",
                table: "Entry");

            migrationBuilder.DropColumn(
                name: "ThemeEntryViewModelId",
                table: "Theme");

            migrationBuilder.DropColumn(
                name: "ThemeEntryViewModelId",
                table: "Entry");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa273449-9362-438d-938b-604fb801ca1a", "AQAAAAEAACcQAAAAEC6bLzXarFy2X5qtpG0YBMjpDKMljroz82M9+YuuwhlWdFGmkz/teDXA/6dvKV+21g==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 6, 15, 57, 24, 671, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 6, 15, 57, 24, 673, DateTimeKind.Local).AddTicks(8941));
        }
    }
}
