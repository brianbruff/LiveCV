using System.ComponentModel.DataAnnotations;

namespace LiveCV.Models
{
    public class Technology
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public virtual TechnologyStats Stats { get; set; }       
    }
}