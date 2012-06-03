using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LiveCV.Models
{
    public class TechnologyStats
    {
        public int ID { get; set; }
        [Required]
        public Competency Competency { get; set; }
        virtual public List<WorkItem> WorkItems { get; set;}
        virtual public List<DateTime> TechDates { get; set; }
    }
}