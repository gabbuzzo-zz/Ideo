using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
   public class VideoCourse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
