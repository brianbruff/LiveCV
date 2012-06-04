using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LiveCV.Models
{
    public class PersonalDetails
    {
        public int ID { get; set; }

        public int ResumeId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address1 { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string Address3 { get; set; }
        [Required]
        public string Address4 { get; set; }
        public string Address5 { get; set; }          
     
        public DateTime Dob { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Website { get; set; }

        public string QualificationSummary { get; set; }

        public string Notes { get; set; }

        //public string Interests { get; set; }

        virtual public List<string> Hobbies { get; set; }

        virtual public List<string> Achievements { get; set; }



    }
}