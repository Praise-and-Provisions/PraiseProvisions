using Microsoft.EntityFrameworkCore;
using PraiseProvisionsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisionsAPI.Data
{
    public class PraiseDBContext : DbContext
    {
        
        public PraiseDBContext(DbContextOptions<PraiseDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Favorites>().HasKey(
                ce => new { ce.ChefID, ce.RestaurantID }
            );

            mb.Entity<Chef>().HasData(
                new Chef
                {
                    ID = 1,
                    FirstName = "Paula",
                    LastName = "Deen",
                    City = "Albany"
                },
                new Chef
                {
                    ID = 2,
                    FirstName = "Gordon",
                    LastName = "Ramsey",
                    City = "Los Angeles"
                },
                new Chef
                {
                    ID = 3,
                    FirstName = "Jimmy",
                    LastName = "Fallon",
                    City = "Jamaica"
                },
                new Chef
                {
                    ID = 4,
                    FirstName = "Jack",
                    LastName = "TheRipper",
                    City = "Omaha"
                }
            );
        }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Favorites> Favorites { get; set; }

    }
}
