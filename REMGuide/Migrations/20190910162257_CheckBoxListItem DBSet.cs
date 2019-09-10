using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class CheckBoxListItemDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c387874-643f-4fb4-8176-a421fe5424ba", "AQAAAAEAACcQAAAAEDK758cs41AeMFlB007c4WB+Wos2gywup/Wd5TXKQFNXbb/JeDMKLUQCdi+sJ+34HQ==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
