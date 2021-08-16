using ArtWebshop.Models;
using System;
using System.Collections.Generic;

namespace ArtWebshop.ViewModels
{
    public class ArtistProductViewModel
    {
        public List<Artist> Artists { get; set; }
        public List<Product> Products { get; set; }
    }
}