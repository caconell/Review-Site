using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class TacoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb; Database=ReviewsitesDB_062021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product(1, "Shrimp Tacos", "/images/spicy-shrimp-tacos.jpg"),
                new Product(2, "Keto Tacos", "/images/Keto-Tacos.jpg"),
                new Product(3, "Ground Beef Tacos", "/images/ground-beef-tacos-3.jpg"),
                new Product(4, "Carnitas Tacos", "/images/carnitas.jpg"),
                new Product(5, "Chicken Tacos", "/images/instant-pot-shredded-chicken-tacos-5.jpg"),
                new Product(6, "Fish Tacos", "/images/fish-taco.jpg"),
                new Product(7, "Veggie Tacos", "/images/Vegetarian-Tacos-3.jpg")
                );

            modelBuilder.Entity<Review>().HasData(
               new Review(1, 6, "userreviewer", "this tacos great")
               );
        }
    }
}
