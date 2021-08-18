using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.ViewModels
{
    public class CheckoutViewModel
    {
        public Order order { get; set; }

        public ShoppingCart shoppingCart { get; set; }
    }
}
