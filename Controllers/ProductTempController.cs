using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{
    public class ProductTempController : Controller
    {
        public ProductTempController(ILogger<HomeController> logger, ProductDbContext prodContext)
        {
            _logger = logger;
            _prodContext = prodContext;
        }

        private readonly ProductDbContext _prodContext;
        private readonly ILogger<HomeController> _logger;

        ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
        List<Product> Products = new List<Product>();
        //public async Task<IActionResult> Index()
        //{
        //    ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
        //    artProdViewModel.Products = await _prodContext.Products.OrderBy(p => p.Title).Include(a => a.Artist).ToListAsync();
        //    return View(artProdViewModel);
        //}
        public async Task<IActionResult> Index()
        {
            
            Products = await _prodContext.Products.OrderBy(p => p.Title).Include(a => a.Artist).ToListAsync();
            return View(Products);
        }

        [HttpPost]
        public async Task<IActionResult> SortFilter(string ascDesc, string sortCriteria)
        {
            if (ascDesc == "asc")
            {
                switch (sortCriteria)
                {
                    case "title":
                        Products = await _prodContext.Products.OrderBy(p => p.Title).Include(a => a.Artist).ToListAsync();
                        break;
                    case "artist":
                        Products = await _prodContext.Products.Include(p => p.Artist).OrderBy(p => p.Artist.ArtistName).ToListAsync();
                        break;
                    case "price":
                        Products = await _prodContext.Products.OrderBy(p => p.Price).Include(a => a.Artist).ToListAsync();
                        break;
                    default:
                        Products = await _prodContext.Products.OrderBy(p => p.Title).Include(a => a.Artist).ToListAsync();
                        break;
                }
            }
            else
            {
                switch (sortCriteria)
                {
                    case "title":
                        Products = await _prodContext.Products.OrderByDescending(p => p.Title).Include(a => a.Artist).ToListAsync();
                        break;
                    case "artist":
                        Products = await _prodContext.Products.Include(a => a.Artist).OrderByDescending(p => p.Artist.ArtistName).ToListAsync();
                        break;
                    case "price":
                        Products = await _prodContext.Products.OrderByDescending(p => p.Price).Include(a => a.Artist).ToListAsync();
                        break;
                    default:
                        Products = await _prodContext.Products.OrderByDescending(p => p.Title).Include(a => a.Artist).ToListAsync();
                        break;
                }
            }

            return View("Index", Products);
        }
        public async Task<IActionResult> SearchFilter(string filter)
        {
            filter = (String.IsNullOrEmpty(filter)) ? "" : filter;

            Products = await _prodContext.Products
                .OrderBy(p => p.Title)
                .Where(p => p.Title.StartsWith(filter))
                .Include(a => a.Artist)
                .ToListAsync();
            
            return View("Index", Products);            
        }
        public async Task<IActionResult> Info(string title)
        {
            artProdViewModel.Products = await _prodContext.Products
                .OrderBy(p => p.Title)
                .Where(p => p.Title == title)
                .Include(a => a.Artist)
                .ToListAsync();
            
            return View(artProdViewModel);
        }
    }
}