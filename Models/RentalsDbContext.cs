using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class RentalsDbContext:DbContext
    {
        public RentalsDbContext(DbContextOptions<RentalsDbContext> options) : base(options)
        {

        }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }       
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Payment> Payments { get;set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
            modelBuilder.Entity<Role>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Category>().HasKey(s => s.Id);
            modelBuilder.Entity<Location>().HasKey(s => s.Id);
            modelBuilder.Entity<Bookings>().HasKey(s => s.Id);
            modelBuilder.Entity<Car>().HasKey(s => s.Id);
            modelBuilder.Entity<Customer>().Property(u => u.Email)
                .IsRequired();
            modelBuilder.Entity<UserRole>().HasKey(ur => ur.Id);
            // modelBuilder.Entity<User>().HasMany(u => u.Users).WithOne(ur => ur.Customer).HasForeignKey(ur => ur.UserId);
            //modelBuilder.Entity<Role>().HasMany(r => r.Users).WithOne(ur => ur.Admin).HasForeignKey(ur => ur.);
            modelBuilder.Entity<User>().HasOne(u => u.Admin).WithOne(s => s.User);
            modelBuilder.Entity<User>().HasOne(u => u.Customer).WithOne(i => i.User);
            modelBuilder.Entity<Car_CarCategory>().HasKey(ur => ur.Id);
            modelBuilder.Entity<Car>().HasMany(u => u.CarCarCategories).WithOne(ur => ur.Car).HasForeignKey(ur => ur.CarId);
            modelBuilder.Entity<Category>().HasMany(r => r.CarCarCategories).WithOne(ur => ur.Category).HasForeignKey(ur => ur.CategoryId);
            modelBuilder.Entity<User>().HasOne(u => u.Role).WithMany(r => r.Users);
            base.OnModelCreating(modelBuilder);
        }
    }
}
