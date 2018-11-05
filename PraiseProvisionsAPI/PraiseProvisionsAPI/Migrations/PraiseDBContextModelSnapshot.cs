﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PraiseProvisionsAPI.Data;

namespace PraiseProvisionsAPI.Migrations
{
    [DbContext(typeof(PraiseDBContext))]
    partial class PraiseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PraiseProvisionsAPI.Models.Chef", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Chefs");

                    b.HasData(
                        new { ID = 1, City = "Albany", FirstName = "Paula", LastName = "Deen" }
                    );
                });

            modelBuilder.Entity("PraiseProvisionsAPI.Models.Favorites", b =>
                {
                    b.Property<int>("ChefID");

                    b.Property<int>("RestaurantID");

                    b.HasKey("ChefID", "RestaurantID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("PraiseProvisionsAPI.Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("PraiseProvisionsAPI.Models.Favorites", b =>
                {
                    b.HasOne("PraiseProvisionsAPI.Models.Chef", "Chef")
                        .WithMany("Favorites")
                        .HasForeignKey("ChefID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PraiseProvisionsAPI.Models.Restaurant", "Restaurant")
                        .WithMany("Favorites")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
