using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class RentalsDbContext : DbContext
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
        public DbSet<Payment> Payments { get; set; }

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
            modelBuilder.Entity<UserRole>().HasIndex(U => U.UserId);
            modelBuilder.Entity<UserRole>().HasIndex(u => u.RoleId);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<User>().HasData(
                  new User
                   {
                    Id = 1,
                   FirstName = "Jafar",
                   MiddleName= "Okikiola",
                    LastName = "Lawal",
                    Gender ="Male",
                    Email = "okikiolalawal@gmail.com",
                    DateOfBirth = DateTime.Now,
                    PhoneNo = "09071681776",
                    Address ="Asero,Abk",
                   PasswordHash = "SehzKv9PAiawVd3TeV1QkkgBlCz67YoY7WMm4FB836c=",
                   HashSalt = "d+RzYMAQvvCJ+aNedX1uDg=="
                  }
                );
            modelBuilder.Entity<Role>().HasData(
             new Role { Id = 1, Name = "SuperAdmin",CreatedAt = DateTime.Now }, new Role { Id = 2, Name = "Admin", CreatedAt = DateTime.Now }, new Role { Id = 3, Name = "Customer" , CreatedAt = DateTime.Now }
            );
            modelBuilder.Entity<UserRole>().HasData(new UserRole {Id=1, UserId = 1, RoleId = 1,CreatedAt = DateTime.Now });

            base.OnModelCreating(modelBuilder);
        }
    }
}
