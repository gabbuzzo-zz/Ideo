using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
   public class User
    {
        public Guid Id { get; set; }
        public string FiscalCode { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Curriculum { get; set; }
        public List<JobApplication> JobApplications { get; set; }
        public List<Post> Posts { get; set; }
        public List<VideoCourse> VideoCourses { get; set; }
        public List<Message> Messages { get; set; }
    }
}
