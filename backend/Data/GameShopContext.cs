using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using backend.Model;


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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .Property(g => g.Price)
                .HasColumnType("decimal(18, 2)"); 
                
        }

    }
}