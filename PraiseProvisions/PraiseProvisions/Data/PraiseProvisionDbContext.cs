using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Data
{
    public class PraiseProvisionDbContext : DbContext
    {
        public PraiseProvisionDbContext(DbContextOptions<PraiseProvisionDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Seed values loaded into the database, mainly used for testing functionality
        /// </summary>
        /// <param name="modelBuilder">The model builder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFavorite>().HasKey(uf => new { uf.RestaurantID, uf.UserProfileID });
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile
                {
                    ID = 1,
                    fullName = "Jimmy Nguyen"
                },

                new UserProfile
                {
                    ID = 2,
                    fullName = "Brian Nelson"
                });

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    ID = 1,
                    Name = "Dough Zone",
                    Address = "1234 Fake St. Seattle, WA 98122",
                    Description = "Brian's delicious comfort food, the dumplings are A+!"
                },


                new Restaurant
                {
                    ID = 2,
                    Name = "Karaage Setsuna",
                    Address = "1234 Fake St. Seattle, WA 98122",
                    Description = "Top fried chicken in Seattle according to Jeff Weng!"
                },
                new Restaurant
                {
                    ID = 3,
                    Name = "Novilho's Brazilian Steakhouse",
                    Address = "1234 Fake St. Seattle, WA 98122",
                    Description = "ALL YOU CAN EAT MEAT. ALL DAY, EVERYDAY."
                });

            modelBuilder.Entity<UserFavorite>().HasData(
                new UserFavorite
                {
                    UserProfileID = 1,
                    RestaurantID = 3
                },

                new UserFavorite
                {
                    UserProfileID = 1,
                    RestaurantID = 2
                },

                new UserFavorite
                {
                    UserProfileID = 2,
                    RestaurantID = 1
                });

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
    }
}
