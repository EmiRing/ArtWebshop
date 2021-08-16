using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.ViewModels
{
    public class UserViewModel
    {
        public ApplicationUser User { get; set; }
        public IList<string> Roles { get; set; }
        public string Password { get; set; }
    }
}
