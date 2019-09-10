using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class CheckBoxListItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Theme_Entry_EntryId",
                table: "Theme");

            migrationBuilder.DropIndex(
                name: "IX_Theme_EntryId",
                table: "Theme");

            migrationBuilder.DropColumn(
                name: "EntryId",
                table: "Theme");

            migrationBuilder.CreateTable(
                name: "CheckBoxListItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Display = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    EntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckBoxListItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckBoxListItem_Entry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9eb4f527-734d-4100-814d-5bf656d8a6b7", "AQAAAAEAACcQAAAAELfUbx45i+CvBfCCWfLpxlm8QFhnNzzA1Qz+TR2mLFGA9e+zxgr1U0+Cjkx4VR3QIQ==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 10, 11, 15, 11, 143, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 10, 11, 15, 11, 147, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.CreateIndex(
                name: "IX_CheckBoxListItem_EntryId",
                table: "CheckBoxListItem",
                column: "EntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckBoxListItem");

            migrationBuilder.AddColumn<int>(
                name: "EntryId",
                table: "Theme",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7d89d8c-eb2e-4ceb-91a5-4eec90d91543", "AQAAAAEAACcQAAAAEAWPCLe55r9BRyaPnOIO6QJc1YJMY7cv14+VJbXCyFHrp6yotAW+C51IMQnM4Otv9w==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 35, 45, 211, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 8, 22, 35, 45, 217, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.CreateIndex(
                name: "IX_Theme_EntryId",
                table: "Theme",
                column: "EntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Theme_Entry_EntryId",
                table: "Theme",
                column: "EntryId",
                principalTable: "Entry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
