
using System;
using System.Collections.Generic;
namespace LiveCV.Models
{
    public class EducationDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Qualification { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        virtual public List<TechCategory> Modules { get; set; }
    }
}