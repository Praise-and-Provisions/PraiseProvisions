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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFavorite>().HasKey(uf => new { uf.RestaurantID, uf.UserProfileID });
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
    }
}
