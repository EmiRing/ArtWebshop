using ArtWebshop.Models;
using System.Collections.Generic;

namespace ArtWebshop.ViewModels
{
    public class ArtistProductViewModel
    {
        public List<Artist> Artist { get; set; }
        public List<Product> Product { get; set; }
    }
}