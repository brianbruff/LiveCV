using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveCV.Models
{
    public class WorkDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string CompanyDescription { get; set; }
        [MaxLength]
        public string Description { get; set; }
        [MaxLength]
        public string Technologies { get; set; }        
        public virtual List<WorkItem> WorkItems { get; set; }        
    }

   
}