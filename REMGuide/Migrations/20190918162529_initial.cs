using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REMGuide.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entry_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SleepCycle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Disruptions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepCycle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SleepCycle_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "ThemeEntry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryId = table.Column<int>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThemeEntry_Entry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThemeEntry_Theme_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "c1ce035f-391a-4b70-bb92-c79c55534afb", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHmT+fHXh6PObgvMdmqWAWPMKQ4WMHYMzszvygoTkBSCgaTUqWLKae0UYmANEHeg/g==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Theme",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A stress dream or anxiety dream is an unpleasant dream which is characterized by feelings of distress, unease, and apprehension. Dreams may include falling, being naked in public, or loss of teeth.", "Stress" },
                    { 2, "A healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from.", "Healing" },
                    { 3, "Romance in a dream may represent your desire or longing for a personal relationship with someone. Alternatively, it may be a sign that you to too obsessed with something.", "Romance" },
                    { 4, "To dream of a friend represents a quality in yourself based on your most honest feelings about them. Ask yourself what memories or feelings stand out the most about them and see how that quality may apply to your own life.", "Friendship" },
                    { 5, "To have a distressful dream may mean that you are feeling incapable of dealing with a problem on your own, or fearing that a problem is impossible. Alternatively, it may be a sign that you are worrying too much about a problem that you don't have enough information about yet.", "Distress" },
                    { 6, "Dreams concerning loss may suggest that your personality or life situation is transforming for better or worse. An area of your life has come to an end, or roles are shifting. You may also be preoccupied with someone else's death or illness.", "Loss" },
                    { 7, "To dream of a family member represents a quality in yourself based on your most honest feelings about them. Alternatively, a dreaming of a family gathering may reflect the various or conflicting aspects of your character as you deal with a situation or problem.", "Family" },
                    { 8, "To dream of an adventure may represent an aspect of yourself that seeks out new challenges or exciting experiences. Perhaps it's time to try new things, take chances, or expand your horizons.", "Adventure" },
                    { 9, "To dream of failure may represent feelings of inadequacy. You may have been unable to prove yourself in a tough situation. Could be a sign that you are allowing pressure to get to you.", "Failure" },
                    { 10, "To dream of an achievement represents satisfaction with the outcome of a situation, plan, or project.", "Achievement" },
                    { 11, "Dreams of violence may represent mental or emotional conflict or struggle with certain aspects of your personality. You may have negative thoughts or emotions like fears, desires, guilt, envy, or other issues that you are confronting or struggling with in your waking life.", "Violence" },
                    { 12, "To dream of fear may reflect a waking life situation that gives you anxiety. It may also reflect an unconscious aversion you have in real life.", "Fear" },
                    { 13, "Joyful dreams may refelct feelings of relief, comfort, or contentment with how a situation has turned out in your waking life.", "Joy" },
                    { 14, "Dreams that make you feel confused may mirror waking life situations where you are unsure. You may be allowing your sense of obligation or obsession with problem solving to frustrate you or distract you.", "Confusion" },
                    { 15, "To dream of jealousy may represent a concern that some area of your life will be too powerful for you. You may fear that someone or something will get out of control.", "Jealousy" }
                });

            migrationBuilder.InsertData(
                table: "Entry",
                columns: new[] { "Id", "Date", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "In the beginning, Heather and I were hanging out, wondering what we could do for fun. So we went to Walmart and bought 1000 marshmellows, and filled the bathtub with as many as we could. After that we ate all of them and I threw up on Heather", "Bathtub Full of Marshmellows", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "I was flying over the entire earth, and I saw all of my friends and family waving at me from high above the clouds. I waved back at them, and kept flying until I get to France. In France I ate a croissant.", "Flying", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "SleepCycle",
                columns: new[] { "Id", "Date", "Disruptions", "Month", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 18, 11, 25, 27, 189, DateTimeKind.Local).AddTicks(8609), 2, 9, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, new DateTime(2019, 9, 18, 11, 25, 27, 189, DateTimeKind.Local).AddTicks(9173), 4, 9, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[] { 2, 1, 9 });

            migrationBuilder.InsertData(
                table: "ThemeEntry",
                columns: new[] { "Id", "EntryId", "ThemeId" },
                values: new object[] { 3, 2, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheckBoxListItem_EntryId",
                table: "CheckBoxListItem",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_UserId",
                table: "Entry",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SleepCycle_UserId",
                table: "SleepCycle",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeEntry_EntryId",
                table: "ThemeEntry",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeEntry_ThemeId",
                table: "ThemeEntry",
                column: "ThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CheckBoxListItem");

            migrationBuilder.DropTable(
                name: "SleepCycle");

            migrationBuilder.DropTable(
                name: "ThemeEntry");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
