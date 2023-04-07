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
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cde fr creating item class in databse
           
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

            modelBuilder.Entity<Item>()
            .HasOne(i => i.List)
            .WithMany(l => l.Items)
            .HasForeignKey(i => i.ListId)
            .OnDelete(DeleteBehavior.Restrict);

            //cde fr list class
            modelBuilder.Entity<List>()
            .HasKey(l => l.Id);

            modelBuilder.Entity<List>()
                .Property(l => l.Title)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<List>()
                .Property(l => l.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<List>()
                .Property(l => l.CreatedDate)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<List>()
                .HasMany(l => l.Items)
                .WithOne(i => i.List)
                .HasForeignKey(i => i.ListId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
