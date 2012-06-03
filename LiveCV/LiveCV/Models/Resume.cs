using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveCV.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }

        [Required]
        public virtual PersonalDetails PersonalDetails { get; set; }

        [Required]
        public virtual List<EducationDetails> Educations { get; set; }

        [Required]
        public virtual List<WorkDetails> WorkDetails { get; set; }

        //[Required]
        public virtual List<WorkDetails> Freelance { get; set; }

        public virtual List<TechCategory> TechCategories { get; set; }

        public virtual List<Books> Books { get; set; }

        //public virtual List<TechnologyStats> TechStats { get; set; }
    }
}