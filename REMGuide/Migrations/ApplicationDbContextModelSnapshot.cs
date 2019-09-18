﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REMGuide.Data;

namespace REMGuide.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("REMGuide.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "14434201-a138-4c0c-8507-1180d85bb45d",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE/5EbKBzHURMCSyjZ4AZDBFUFSiE9KHqw5TH+FMVsKo4JtxJBOQ9DL78rw1cy6plA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("REMGuide.Models.CheckBoxListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Display");

                    b.Property<int?>("EntryId");

                    b.Property<bool>("IsChecked");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.ToTable("CheckBoxListItem");
                });

            modelBuilder.Entity("REMGuide.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Entry");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "In the beginning, Heather and I were hanging out, wondering what we could do for fun. So we went to Walmart and bought 1000 marshmellows, and filled the bathtub with as many as we could. After that we ate all of them and I threw up on Heather",
                            Title = "Bathtub Full of Marshmellows",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "I was flying over the entire earth, and I saw all of my friends and family waving at me from high above the clouds. I waved back at them, and kept flying until I get to France. In France I ate a croissant.",
                            Title = "Flying",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("REMGuide.Models.SleepCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Disruptions");

                    b.Property<int>("Month");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SleepCycle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 9, 18, 11, 20, 31, 730, DateTimeKind.Local).AddTicks(965),
                            Disruptions = 2,
                            Month = 9,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 9, 18, 11, 20, 31, 730, DateTimeKind.Local).AddTicks(1788),
                            Disruptions = 4,
                            Month = 9,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("REMGuide.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Theme");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A stress dream or anxiety dream is an unpleasant dream which is characterized by feelings of distress, unease, and apprehension. Dreams may include falling, being naked in public, or loss of teeth.",
                            Name = "Stress"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from.",
                            Name = "Healing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Romance in a dream may represent your desire or longing for a personal relationship with someone. Alternatively, it may be a sign that you to too obsessed with something.",
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Description = "To dream of a friend represents a quality in yourself based on your most honest feelings about them. Ask yourself what memories or feelings stand out the most about them and see how that quality may apply to your own life.",
                            Name = "Friendship"
                        },
                        new
                        {
                            Id = 5,
                            Description = "To have a distressful dream may mean that you are feeling incapable of dealing with a problem on your own, or fearing that a problem is impossible. Alternatively, it may be a sign that you are worrying too much about a problem that you don't have enough information about yet.",
                            Name = "Distress"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Dreams concerning loss may suggest that your personality or life situation is transforming for better or worse. An area of your life has come to an end, or roles are shifting. You may also be preoccupied with someone else's death or illness.",
                            Name = "Loss"
                        },
                        new
                        {
                            Id = 7,
                            Description = "To dream of a family member represents a quality in yourself based on your most honest feelings about them. Alternatively, a dreaming of a family gathering may reflect the various or conflicting aspects of your character as you deal with a situation or problem.",
                            Name = "Family"
                        },
                        new
                        {
                            Id = 8,
                            Description = "To dream of an adventure may represent an aspect of yourself that seeks out new challenges or exciting experiences. Perhaps it's time to try new things, take chances, or expand your horizons.",
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 9,
                            Description = "To dream of failure may represent feelings of inadequacy. You may have been unable to prove yourself in a tough situation. Could be a sign that you are allowing pressure to get to you.",
                            Name = "Failure"
                        },
                        new
                        {
                            Id = 10,
                            Description = "To dream of an achievement represents satisfaction with the outcome of a situation, plan, or project.",
                            Name = "Achievement"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Dreams of violence may represent mental or emotional conflict or struggle with certain aspects of your personality. You may have negative thoughts or emotions like fears, desires, guilt, envy, or other issues that you are confronting or struggling with in your waking life.",
                            Name = "Violence"
                        },
                        new
                        {
                            Id = 12,
                            Description = "To dream of fear may reflect a waking life situation that gives you anxiety. It may also reflect an unconscious aversion you have in real life.",
                            Name = "Fear"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Joyful dreams may refelct feelings of relief, comfort, or contentment with how a situation has turned out in your waking life.",
                            Name = "Joy"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Dreams that make you feel confused may mirror waking life situations where you are unsure. You may be allowing your sense of obligation or obsession with problem solving to frustrate you or distract you.",
                            Name = "Confusion"
                        },
                        new
                        {
                            Id = 15,
                            Description = "To dream of jealousy may represent a concern that some area of your life will be too powerful for you. You may fear that someone or something will get out of control.",
                            Name = "Jealousy"
                        });
                });

            modelBuilder.Entity("REMGuide.Models.ThemeEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntryId");

                    b.Property<int>("ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.HasIndex("ThemeId");

                    b.ToTable("ThemeEntry");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EntryId = 1,
                            ThemeId = 2
                        },
                        new
                        {
                            Id = 2,
                            EntryId = 1,
                            ThemeId = 9
                        },
                        new
                        {
                            Id = 3,
                            EntryId = 2,
                            ThemeId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("REMGuide.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("REMGuide.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("REMGuide.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("REMGuide.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("REMGuide.Models.CheckBoxListItem", b =>
                {
                    b.HasOne("REMGuide.Models.Entry")
                        .WithMany("Themes")
                        .HasForeignKey("EntryId");
                });

            modelBuilder.Entity("REMGuide.Models.Entry", b =>
                {
                    b.HasOne("REMGuide.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("REMGuide.Models.SleepCycle", b =>
                {
                    b.HasOne("REMGuide.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("REMGuide.Models.ThemeEntry", b =>
                {
                    b.HasOne("REMGuide.Models.Entry", "Entry")
                        .WithMany("ThemeEntries")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("REMGuide.Models.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
