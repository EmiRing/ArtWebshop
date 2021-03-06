using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        
        [Required]
        [PersonalData]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Adress")]
        public string DeliveryStreetName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Postnummer")]
        public string DeliveryPostalCode { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Stad")]        
        public string DeliveryCity { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Land")]        
        public string DeliveryCountry { get; set; }

        
        [PersonalData]
        [Display(Name = "Adress")]
        public string BillingStreetName { get; set; }

        
        [PersonalData]
        [Display(Name = "Postnummer")]
        public string BillingPostalCode { get; set; }

        
        [PersonalData]
        [Display(Name = "Stad")]
        public string BillingCity { get; set; }

        [PersonalData]
        [Display(Name = "Land")]
        public string BillingCountry { get; set; }


        [NotMapped]
        [Display(Name = "Full name")]
        public string FullName
        {
            get
            {
                return LastName == null ? FirstName : FirstName + " " + LastName;
            }
        }

    }

}
