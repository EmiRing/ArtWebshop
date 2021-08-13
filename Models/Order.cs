using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string DeliveryStreetName { get; set; }
        [Required]
        public string DeliveryPostalCode { get; set; }
        [Required]
        public string DeliveryCity { get; set; }
        [Required]
        public string DeliveryCountry { get; set; }

        public string BillingStreetName { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        public string CouponId { get; set; }

        //public ApplicationUser User { get; set; }
        public List<OrderRow> OrderRows { get; set; }

    }
}
