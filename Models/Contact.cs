using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleContactList.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Contact Type")]
        public string ContactType { get; set; } // Values: Business || Personal

        [Required]
        [StringLength(40)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(40)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } // Values: Male || Female

        [EmailAddress]
        [StringLength(200)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        [Display(Name = "State / Province / County")]
        public string State_Province_County { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(20)]
        public string Zipcode { get; set; }

        [Timestamp]
        public Byte[] Created { get; set; }
    }
}