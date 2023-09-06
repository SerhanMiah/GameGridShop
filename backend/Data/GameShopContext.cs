using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using backend.Model;
using backend.Data.SeedData;
using backend.Model.VideoGame;


namespace backend.Data
{
    public class GameShopContext : IdentityDbContext<ApplicationUser> 
    {
        public GameShopContext(DbContextOptions<GameShopContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<GameImage> GameImages { get; set; }

        public DbSet<CartItem> CartItems { get; set; } 
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } 

        public DbSet<GameTag> GameTags { get; set; } 
        public DbSet<Tag> Tags { get; set; }
        public DbSet<DLC> DLCs { get; set; }
        public DbSet<Edition> Editions { get; set; }



protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            GameSeedData.Seed(modelBuilder);

            modelBuilder.Entity<Game>()
                .Property(g => g.GameGenre)
                .HasConversion<string>();

            modelBuilder.Entity<Game>()
                .Property(g => g.GamePlatform)
                .HasConversion<string>();

            modelBuilder.Entity<Game>()
                .Property(g => g.Rating)
                .HasConversion<string>();

            // Many-to-many relationship between Game and Tag using GameTag
            modelBuilder.Entity<GameTag>()
                .HasKey(gt => new { gt.GameId, gt.TagId });

            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Game)
                .WithMany(g => g.GameTags)  
                .HasForeignKey(gt => gt.GameId);

            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Tag)
                .WithMany(t => t.GameTags)
                .HasForeignKey(gt => gt.TagId);

            // Configure the one-to-many relationship between Game and Review
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Game)
                .WithMany(g => g.Reviews)
                .HasForeignKey(r => r.GameId); 

        }

    }
}