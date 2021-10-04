using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ideo.Backend.Models;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ideo.Backend.Data
{
    public class IdeoBackendContext : IdentityDbContext<IdentityUser>
    {
        public IdeoBackendContext(DbContextOptions<IdeoBackendContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        //public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VideoCourse> VideoCourses { get; set; }
    }
}
