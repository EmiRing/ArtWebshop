using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Förnamn")]
        public string DeliveryFirstName { get; set; }
        [Required]
        [Display(Name = "Efternamn")]
        public string DeliveryLastName { get; set; }
        [Required]
        [Display(Name = "Adress")]
        public string DeliveryStreetName { get; set; }
        [Required]
        [Display(Name ="Postnummer")]
        public string DeliveryPostalCode { get; set; }
        [Required]
        [Display(Name ="Postort")]
        public string DeliveryCity { get; set; }
        [Required]
        [Display(Name ="Land")]
        public string DeliveryCountry { get; set; }
        [Display(Name = "Förnamn")]
        public string BillingFirstName { get; set; }
        [Display(Name = "Efternamn")]
        public string BillingLastName { get; set; }
        [Display(Name = "Adress")]
        public string BillingStreetName { get; set; }
        [Display(Name = "Postnummer")]
        public string BillingPostalCode { get; set; }
        [Display(Name = "Postort")]
        public string BillingCity { get; set; }
        [Display(Name = "Land")]
        public string BillingCountry { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal OrderTotal { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public string CouponId { get; set; }

        //public ApplicationUser User { get; set; }
        public List<OrderRow> OrderRows { get; set; }

    }
}
