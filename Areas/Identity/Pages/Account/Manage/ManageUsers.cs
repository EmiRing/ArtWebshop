using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Areas.Identity.Pages.Account.Manage
{
    public class Users : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
