using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class EntryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Theme",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14434201-a138-4c0c-8507-1180d85bb45d", "AQAAAAEAACcQAAAAEE/5EbKBzHURMCSyjZ4AZDBFUFSiE9KHqw5TH+FMVsKo4JtxJBOQ9DL78rw1cy6plA==" });

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 18, 11, 20, 31, 730, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "SleepCycle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 18, 11, 20, 31, 730, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A stress dream or anxiety dream is an unpleasant dream which is characterized by feelings of distress, unease, and apprehension. Dreams may include falling, being naked in public, or loss of teeth.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from.", "Healing" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Romance in a dream may represent your desire or longing for a personal relationship with someone. Alternatively, it may be a sign that you to too obsessed with something.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "To dream of a friend represents a quality in yourself based on your most honest feelings about them. Ask yourself what memories or feelings stand out the most about them and see how that quality may apply to your own life.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "To have a distressful dream may mean that you are feeling incapable of dealing with a problem on your own, or fearing that a problem is impossible. Alternatively, it may be a sign that you are worrying too much about a problem that you don't have enough information about yet.", "Distress" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Dreams concerning loss may suggest that your personality or life situation is transforming for better or worse. An area of your life has come to an end, or roles are shifting. You may also be preoccupied with someone else's death or illness.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "To dream of a family member represents a quality in yourself based on your most honest feelings about them. Alternatively, a dreaming of a family gathering may reflect the various or conflicting aspects of your character as you deal with a situation or problem.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "To dream of an adventure may represent an aspect of yourself that seeks out new challenges or exciting experiences. Perhaps it's time to try new things, take chances, or expand your horizons.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "To dream of failure may represent feelings of inadequacy. You may have been unable to prove yourself in a tough situation. Could be a sign that you are allowing pressure to get to you.", "Failure" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "To dream of an achievement represents satisfaction with the outcome of a situation, plan, or project.", "Achievement" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Dreams of violence may represent mental or emotional conflict or struggle with certain aspects of your personality. You may have negative thoughts or emotions like fears, desires, guilt, envy, or other issues that you are confronting or struggling with in your waking life.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "To dream of fear may reflect a waking life situation that gives you anxiety. It may also reflect an unconscious aversion you have in real life.", "Fear" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Joyful dreams may refelct feelings of relief, comfort, or contentment with how a situation has turned out in your waking life.", "Joy" });

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Dreams that make you feel confused may mirror waking life situations where you are unsure. You may be allowing your sense of obligation or obsession with problem solving to frustrate you or distract you.");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "To dream of jealousy may represent a concern that some area of your life will be too powerful for you. You may fear that someone or something will get out of control.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Theme");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c549880d-f4d2-4cfb-a411-845239dacccd", "AQAAAAEAACcQAAAAEKFK2yK7lYtcHrjqeWPGaYi0q25X6c/8OOUxoFu7cmvinYVVW4caCjWnHzXgCqsHow==" });

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

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Rebirth");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Abandonment");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Charity");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Study");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Escape");

            migrationBuilder.UpdateData(
                table: "Theme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Fun");

            migrationBuilder.InsertData(
                table: "Theme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Insanity" });
        }
    }
}
