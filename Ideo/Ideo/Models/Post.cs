using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
   public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SharedFile { get; set; }
        public bool IsAccepted { get; set; }
        public string RefusedCause { get; set; }
        public DateTime PublishDate { get; set; }
        public List<TagCL> Tags { get; set; }
    }
}
