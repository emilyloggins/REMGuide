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

            modelBuilder.Entity<Entry>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<SleepCycle>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Entry>().HasData(
                new Entry()
                {
                    Id = 1,
                    UserId = user.Id,
                    Date = DateTime.Today,
                    Title = "Bathtub Full of Marshmellows",
                    Description = "In the beginning, Heather and I were hanging out, wondering what we could do for fun. So we went to Walmart and bought 1000 marshmellows, and filled the bathtub with as many as we could. After that we ate all of them and I threw up on Heather"
                },
                new Entry()
                {
                    Id = 2,
                    UserId = user.Id,
                    Date = DateTime.Today,
                    Title = "Flying",
                    Description = "I was flying over the entire earth, and I saw all of my friends and family waving at me from high above the clouds. I waved back at them, and kept flying until I get to France. In France I ate a croissant."
                },
                new Entry()
                {
                    Id = 3,
                    UserId = user.Id,
                    Date = DateTime.Today,
                    Title = "Alien Invasion",
                    Description = "They came from the sky. And when they came, they took everyone. The spaceship was cold and metal, but they had some dank chips and salsa tho"
                }
            );

            modelBuilder.Entity<SleepCycle>().HasData(
                new SleepCycle()
                {
                    Id = 1,
                    UserId = user.Id,
                    Month = 9,
                    Date = DateTime.Now,
                    Disruptions = 2
                },
               new SleepCycle()
               {
                   Id = 2,
                   UserId = user.Id,
                   Month = 9,
                   Date = DateTime.Now,
                   Disruptions = 4
               }
            );
            modelBuilder.Entity<ThemeEntry>().HasData(
                new ThemeEntry()
                {
                    Id = 1,
                    EntryId = 1,
                    ThemeId = 1
                },
                new ThemeEntry()
                {
                    Id = 2,
                    EntryId = 1,
                    ThemeId = 4
                },
                new ThemeEntry()
                {
                    Id = 3,
                    EntryId = 2,
                    ThemeId = 8
                },
                new ThemeEntry()
                {
                    Id = 4,
                    EntryId = 2,
                    ThemeId = 8
                },
                new ThemeEntry()
                {
                    Id = 5,
                    EntryId = 2,
                    ThemeId = 13
                },
                new ThemeEntry()
                {
                    Id = 6,
                    EntryId = 3,
                    ThemeId = 1
                },
                new ThemeEntry()
                {
                    Id = 7,
                    EntryId = 3,
                    ThemeId = 11
                }
            );

            modelBuilder.Entity<Theme>().HasData(
                new Theme()
                {
                    Id = 1,
                    Name = "Stress",
                    Description = "A stress dream or anxiety dream is an unpleasant dream which is characterized by feelings of distress, unease, and apprehension. Dreams may include falling, being naked in public, or loss of teeth.",
                },
                new Theme()
                {
                    Id = 2,
                    Name = "Healing",
                    Description = "A dream about healing may represent some area of your life that is being restored. Emotional repair or the restoration of abilities. Healing in a dream may also reflect progress, or difficulties that you are moving on from."
                },
                new Theme()
                {
                    Id = 3,
                    Name = "Romance",
                    Description = "Romance in a dream may represent your desire or longing for a personal relationship with someone. Alternatively, it may be a sign that you to too obsessed with something."
                },
                new Theme()
                {
                    Id = 4,
                    Name = "Friendship",
                    Description = "To dream of a friend represents a quality in yourself based on your most honest feelings about them. Ask yourself what memories or feelings stand out the most about them and see how that quality may apply to your own life."
                },
                new Theme()
                {
                    Id = 5,
                    Name = "Distress",
                    Description = "To have a distressful dream may mean that you are feeling incapable of dealing with a problem on your own, or fearing that a problem is impossible. Alternatively, it may be a sign that you are worrying too much about a problem that you don't have enough information about yet."
                },
                new Theme()
                {
                    Id = 6,
                    Name = "Loss",
                    Description  = "Dreams concerning loss may suggest that your personality or life situation is transforming for better or worse. An area of your life has come to an end, or roles are shifting. You may also be preoccupied with someone else's death or illness."
                },
                new Theme()
                {
                    Id = 7,
                    Name = "Family",
                    Description = "To dream of a family member represents a quality in yourself based on your most honest feelings about them. Alternatively, a dreaming of a family gathering may reflect the various or conflicting aspects of your character as you deal with a situation or problem."
                },
                new Theme()
                {
                    Id = 8,
                    Name = "Adventure",
                    Description = "To dream of an adventure may represent an aspect of yourself that seeks out new challenges or exciting experiences. Perhaps it's time to try new things, take chances, or expand your horizons."
                },
                new Theme()
                {
                    Id = 9,
                    Name = "Failure",
                    Description = "To dream of failure may represent feelings of inadequacy. You may have been unable to prove yourself in a tough situation. Could be a sign that you are allowing pressure to get to you."
                },
                new Theme()
                {
                    Id = 10,
                    Name = "Achievement",
                    Description = "To dream of an achievement represents satisfaction with the outcome of a situation, plan, or project."
                },
                new Theme()
                {
                    Id = 11,
                    Name = "Violence",
                    Description = "Dreams of violence may represent mental or emotional conflict or struggle with certain aspects of your personality. You may have negative thoughts or emotions like fears, desires, guilt, envy, or other issues that you are confronting or struggling with in your waking life."
                },
                new Theme()
                {
                    Id = 12,
                    Name = "Fear",
                    Description = "To dream of fear may reflect a waking life situation that gives you anxiety. It may also reflect an unconscious aversion you have in real life."
                },
                new Theme()
                {
                    Id = 13,
                    Name = "Joy",
                    Description = "Joyful dreams may refelct feelings of relief, comfort, or contentment with how a situation has turned out in your waking life."
                },
                new Theme()
                {
                    Id = 14,
                    Name = "Confusion",
                    Description = "Dreams that make you feel confused may mirror waking life situations where you are unsure. You may be allowing your sense of obligation or obsession with problem solving to frustrate you or distract you."
                },
                new Theme()
                {
                    Id = 15,
                    Name = "Jealousy",
                    Description = "To dream of jealousy may represent a concern that some area of your life will be too powerful for you. You may fear that someone or something will get out of control."
                }
            );
        }
    }
}
