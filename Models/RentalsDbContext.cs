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
        public DbSet<Payment> Payments { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
            modelBuilder.Entity<Role>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Category>().HasKey(s => s.Id);
            modelBuilder.Entity<Location>().HasKey(s => s.Id);
            modelBuilder.Entity<Bookings>().HasKey(s => s.Id);
            modelBuilder.Entity<Car>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().Property(u => u.Email)
                .IsRequired();
            modelBuilder.Entity<UserRole>().HasKey(ur => ur.Id);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles).WithOne(ur => ur.User).HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles).WithOne(ur => ur.Role).HasForeignKey(ur => ur.RoleId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
