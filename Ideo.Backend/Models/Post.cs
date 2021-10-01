using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Models
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
        public List<Tag> Tags { get; set; }
    }
}
