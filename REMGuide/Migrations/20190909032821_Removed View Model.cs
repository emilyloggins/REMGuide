using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class RemovedViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_Entry_ThemeEntryViewModelId",
                table: "Entry");

            migrationBuilder.DropColumn(
                name: "ThemeEntryViewModelId",
                table: "Entry");

            migrationBuilder.RenameColumn(
                name: "ThemeEntryViewModelId",
                table: "Theme",
                newName: "EntryId");

            migrationBuilder.RenameIndex(
                name: "IX_Theme_ThemeEntryViewModelId",
                table: "Theme",
                newName: "IX_Theme_EntryId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "384e6a5f-1531-45f4-a60f-34f86e0c2b47", "AQAAAAEAACcQAAAAED9Cd2UDZDl4DdzQR/u6FJ5PRUfTrrr7G8MmM2HEnyQl/XTtLdkMmfLrzkpRGgD0+Q==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 28, 20, 36, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 28, 20, 42, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.CreateIndex(
                name: "IX_ThemeEntry_EntryId",
                table: "ThemeEntry",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeEntry_ThemeId",
                table: "ThemeEntry",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Theme_Entry_EntryId",
                table: "Theme",
                column: "EntryId",
                principalTable: "Entry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeEntry_Entry_EntryId",
                table: "ThemeEntry",
                column: "EntryId",
                principalTable: "Entry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeEntry_Theme_ThemeId",
                table: "ThemeEntry",
                column: "ThemeId",
                principalTable: "Theme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Theme_Entry_EntryId",
                table: "Theme");

            migrationBuilder.DropForeignKey(
                name: "FK_ThemeEntry_Entry_EntryId",
                table: "ThemeEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_ThemeEntry_Theme_ThemeId",
                table: "ThemeEntry");

            migrationBuilder.DropIndex(
                name: "IX_ThemeEntry_EntryId",
                table: "ThemeEntry");

            migrationBuilder.DropIndex(
                name: "IX_ThemeEntry_ThemeId",
                table: "ThemeEntry");

            migrationBuilder.RenameColumn(
                name: "EntryId",
                table: "Theme",
                newName: "ThemeEntryViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Theme_EntryId",
                table: "Theme",
                newName: "IX_Theme_ThemeEntryViewModelId");

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
    }
}
