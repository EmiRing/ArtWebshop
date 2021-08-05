using ArtWebshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtWebshop.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public override DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedingUsers.seed(modelBuilder);

            //string roleId = Guid.NewGuid().ToString();
            //string userId = Guid.NewGuid().ToString();

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = roleId,
            //        Name = "Admin",
            //        NormalizedName = "ADMIN",
            //        ConcurrencyStamp = roleId
            //    });

            //var adminUser = new ApplicationUser
            //{
            //    Id = userId,
            //    FirstName = "Admin",
            //    LastName = "A",
            //    Email = "admin@site.com",
            //    NormalizedEmail = "ADMIN@SITE.COM",
            //    EmailConfirmed = true,
            //    UserName = "admin@site.com",
            //    NormalizedUserName = "ADMIN@SITE.COM",
            //    BillingStreetName = "Hemadress 1",
            //    BillingPostalCode = "12345",
            //    BillingCity = "Göteborg",
            //    BillingCountry = "Sverige"
            //};

            //PasswordHasher<ApplicationUser> pH = new PasswordHasher<ApplicationUser>();
            //adminUser.PasswordHash = pH.HashPassword(adminUser, "admin");

            //modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        RoleId = roleId,
            //        UserId = userId
            //    });

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "User",
            //        NormalizedName = "USER",
            //        ConcurrencyStamp = Guid.NewGuid().ToString()
            //    });

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "Artist",
            //        NormalizedName = "ARTIST",
            //        ConcurrencyStamp = Guid.NewGuid().ToString()
            //    });

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "Vendor",
            //        NormalizedName = "VENDOR",
            //        ConcurrencyStamp = Guid.NewGuid().ToString()
            //    });


        }
    }
}
