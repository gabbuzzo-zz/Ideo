using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
    public class Report
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public ReportType ReportType { get; set; }

    }
}
