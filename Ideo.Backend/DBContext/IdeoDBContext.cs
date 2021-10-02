using Ideo.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.DBContext
{
    public class IdeoDBContext : DbContext
    {
        public IdeoDBContext(DbContextOptions<IdeoDBContext> options): base(options)
        {

        }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VideoCourse> VideoCourses { get; set; }
    }
}
