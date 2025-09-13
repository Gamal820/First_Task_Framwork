using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales_Mangment.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sales_Mangment.DataAccess
{
    internal class AplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Data Source=DESKTOP-90TMC45\\MSSQLSERVER2;Database=Sales Mangment; ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProductId is Primary key
            modelBuilder.Entity<Product>().HasKey(e => e.ProductId);

            //Name(up to 50 characters, unicode)
            modelBuilder.Entity<Product>().Property(e => e.Name)
           .HasMaxLength(50).IsUnicode(true);
            //Quantity(real number)
            modelBuilder.Entity<Product>().Property(e => e.Quantity).HasColumnType("real");

            //  CustomerId is Primary key
            modelBuilder.Entity<Customer>().HasKey(e => e.CustomerId);
            //Name(up to 100 characters, unicode)
            modelBuilder.Entity<Customer>().Property(e => e.Name)
                .HasMaxLength(100).IsUnicode(true);
            //Email(up to 80 characters, not unicode)
            modelBuilder.Entity<Customer>().Property(e => e.Email)
                .HasMaxLength(80).IsUnicode(false);
            //CreaditCardNumber(string)
            modelBuilder.Entity<Customer>().Property(e => e.CreaditCardNumber).IsUnicode(false);
            // StoreId is Primary key
            modelBuilder.Entity<Store>().HasKey(e => e.StoreId);
            //Name(up to 80 characters, unicode)
            modelBuilder.Entity<Store>().Property(e => e.Name)
                .HasMaxLength(80).IsUnicode(true);
            // SaleId is Primary key
            modelBuilder.Entity<Sale>().HasKey(e => e.SaleId);

            //Products Migration For table Products add string column Description

            modelBuilder.Entity<Product>().Property(e => e.Description)
               .HasMaxLength(250).IsUnicode(true).HasDefaultValue("No description");
            //For table Sales make Date column with default value GETDATE() function,

            modelBuilder.Entity<Sale>().Property(e => e.Date).HasDefaultValueSql("GETDATE()");












        }
    }
}




