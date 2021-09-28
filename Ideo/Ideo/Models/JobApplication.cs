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
        public MessageCL Message { get; set; }
        public PostCL Post { get; set; }
        public List<ReportCL> Reports { get; set; }

    }
}
