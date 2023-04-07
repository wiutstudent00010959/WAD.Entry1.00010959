using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.CW._00010959.Models
{
    public class ItemContext : DbContext
    {

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(i => i.Title)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Item>()
                .Property(i => i.Quantity)
                .IsRequired()
                .HasDefaultValue(0);

            modelBuilder.Entity<Item>()
                .Property(i => i.IsPurchased)
                .IsRequired()
                .HasDefaultValue(false);

            modelBuilder.Entity<Item>()
                .Property(i => i.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Item>()
                .Property(i => i.PurchaseDate)
                .IsRequired()
                .HasColumnType("date");
        }

    }
}
