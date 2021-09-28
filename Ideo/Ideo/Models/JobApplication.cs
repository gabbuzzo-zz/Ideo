using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
   public class JobApplication
    {
        public Guid Id { get; set; }
        public bool isAccepted { get; set; }
        public string Curriculum { get; set; }
        public DateTime SendDate { get; set; }
        public Message Message { get; set; }
        public Post Post { get; set; }
        public List<Report> Reports { get; set; }

    }
}
