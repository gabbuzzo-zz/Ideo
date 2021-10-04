using Ideo.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Data
{
    public static class SeederDB
    {
         
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedUsers(modelBuilder);
            SeedRoles(modelBuilder);
            SeedUserRoles(modelBuilder);
        }


        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var ph = new PasswordHasher<User>();
            var user1 = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Gabbuzzo",
                NormalizedUserName = "gabbuzzo".ToUpper(),
                Email = "gabbuzzo@admin.com",
                EmailConfirmed = true,
            };
            user1.PasswordHash = ph.HashPassword(user1, "Gabbuzzoadmin");


            modelBuilder.Entity<User>().HasData(user1);

        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin_role",
                    Name = "admin",
                    NormalizedName = "admin".ToUpper(),
                });
                //new IdentityRole
                //{
                //    Id = "reader_role",
                //    Name = "reader",
                //    NormalizedName = "reader".ToUpper()
                //});
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "admin_role",
                    UserId = "1"
                });
                //new IdentityUserRole<string>
                //{
                //    RoleId = "reader_role",
                //    UserId = "2"
                //});
        }
    }
}
