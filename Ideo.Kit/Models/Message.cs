using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Kit.Models
{
   public class Message
    {
        public Guid Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }
    }
}
