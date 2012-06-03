using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveCV.Models
{
    public class TechCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Technology> Technologies { get; set; }
    }
}