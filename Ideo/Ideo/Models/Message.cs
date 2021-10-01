using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
   public class Message
    {
        public Guid Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }
    }
}
