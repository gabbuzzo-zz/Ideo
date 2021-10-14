using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.Models
{
    public class User:IdentityUser
    {
        public string FiscalCode { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Curriculum { get; set; }
        public DateTime BirthdayDate { get; set; }
        public List<JobApplication> JobApplications { get; set; }
        public List<Post> Posts { get; set; }
        public List<VideoCourse> VideoCourses { get; set; }
        public List<Message> Messages { get; set; }
    }
}
