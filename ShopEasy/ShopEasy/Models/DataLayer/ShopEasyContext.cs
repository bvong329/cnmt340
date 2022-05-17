using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopEasy.Models.DataLayer
{
    public partial class ShopEasyContext : DbContext
    {
        public ShopEasyContext()
        {
        }

        public ShopEasyContext(DbContextOptions<ShopEasyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=H:\\Visual Studio Repository\\ShopEasy\\ShopEasy\\SHOPEASYDB.mdf;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.Lname).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.Responsible).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerId).IsUnicode(false);

                entity.Property(e => e.Date).IsUnicode(false);

                entity.Property(e => e.Cost).IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
