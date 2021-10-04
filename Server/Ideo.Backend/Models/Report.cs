using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Models
{
    public class Report
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public ReportType ReportType { get; set; }

    }
}
