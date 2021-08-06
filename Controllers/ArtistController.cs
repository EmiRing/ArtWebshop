using ArtWebshop.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ProductDbContext _productDbContext;
        private readonly AppDbContext _appDbContext;

        public ArtistController(ProductDbContext productDbContext, AppDbContext appDbContext)
        {
            _productDbContext = productDbContext;
            _appDbContext = appDbContext;
        }
        public IActionResult ProfilePage(string ArtistId)
        {

            return View();
        }
    }
}
