using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using REMGuide.Models;

namespace REMGuide.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Entry> Entry { get; set; }
        public DbSet<SleepCycle> SleepCycle { get; set; }
        public DbSet<Theme> Theme { get; set; }
        public DbSet<ThemeEntry> ThemeEntry { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Entry>().HasData(
                new Entry()
                {
                    Id = 1,
                    UserId = 1,
                    Title = "Bathtub Full of Marshmellows",
                    Description = "In the beginning, Heather and I were hanging out, wondering what we could do for fun. So we went to Walmart and bought 1000 marshmellows, and filled the bathtub with as many as we could. After that we ate all of them and I threw up on Heather"
                },
                new Entry()
                {
                    Id = 2,
                    UserId = 1,
                    Title = "Flying",
                    Description = "I was flying over the entire earth, and I saw all of my friends and family waving at me from high above the clouds. I waved back at them, and kept flying until I get to France. In France I ate a croissant."
                }
            );

            modelBuilder.Entity<SleepCycle>().HasData(
                new SleepCycle()
                {
                    Id = 1,
                    UserId = 1,
                    Date = DateTime.Now,
                    Disruptions = 2
                },
               new SleepCycle()
               {
                   Id = 2,
                   UserId = 1,
                   Date = DateTime.Now,
                   Disruptions = 4
               }
            );
            modelBuilder.Entity<ThemeEntry>().HasData(
                new ThemeEntry()
                {
                    Id = 1,
                    EntryId = 1,
                    ThemeId = 2
                },
                new ThemeEntry()
                {
                    Id = 2,
                    EntryId = 1,
                    ThemeId = 9
                },
                new ThemeEntry()
                {
                    Id = 3,
                    EntryId = 2,
                    ThemeId = 5
                }
            );

            modelBuilder.Entity<Theme>().HasData(
                new Theme()
                {
                    Id = 1,
                    Name = "Stress"
                },
                new Theme()
                {
                    Id = 2,
                    Name = "Rebirth"
                },
                new Theme()
                {
                    Id = 3,
                    Name = "Romance"
                },
                new Theme()
                {
                    Id = 4,
                    Name = "Friendship"
                },
                new Theme()
                {
                    Id = 5,
                    Name = "Abandonment"
                },
                new Theme()
                {
                    Id = 6,
                    Name = "Loss"
                },
                new Theme()
                {
                    Id = 7,
                    Name = "Family"
                },
                new Theme()
                {
                    Id = 8,
                    Name = "Adventure"
                },
                new Theme()
                {
                    Id = 9,
                    Name = "Charity"
                },
                new Theme()
                {
                    Id = 10,
                    Name = "Study"
                },
                new Theme()
                {
                    Id = 11,
                    Name = "Violence"
                },
                new Theme()
                {
                    Id = 12,
                    Name = "Escape"
                },
                new Theme()
                {
                    Id = 13,
                    Name = "Fun"
                },
                new Theme()
                {
                    Id = 14,
                    Name = "Confusion"
                },
                new Theme()
                {
                    Id = 15,
                    Name = "Jealousy"
                },
                new Theme()
                {
                    Id = 16,
                    Name = "Insanity"
                }

            );
        }
    }
}
