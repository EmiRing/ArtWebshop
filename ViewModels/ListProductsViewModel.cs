using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.ViewModels
{
    public class ListProductsViewModel
    {
        public List<Product> Products { get; set; }

        public string sortCriteria { get; set; }
        public string ascDesc { get; set; }
    }
}
