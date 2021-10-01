using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }
    }
}
