using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveCV.Models
{
    public class WorkItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}