using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.Repositories;
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

        public ProductTempController(ILogger<HomeController> logger, ProductDbContext prodContext, IRepository<Product> productRepository)
        {
            _logger = logger;
            _prodContext = prodContext;
            _productRepository = productRepository;
        }

        private readonly ProductDbContext _prodContext;
        private readonly IRepository<Product> _productRepository;
        private readonly ILogger<HomeController> _logger;

        ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
        List<Product> Products = new List<Product>();
        //public async Task<IActionResult> Index()
        //{
        //    ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
        //    artProdViewModel.Products = await _prodContext.Products.OrderBy(p => p.Title).Include(a => a.Artist).ToListAsync();
        //    return View(artProdViewModel);
        //}
        public async Task<IActionResult> Index(string ascDesc = "asc", string sortCriteria = "title")
        {
            
            //Products = await _prodContext.Products.Include(a => a.Artist).ToListAsync();
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

            return View(new ListProductsViewModel
            {
                Products = Products,
                sortCriteria = sortCriteria,
                ascDesc = ascDesc
            });

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

            return View("Index", new ListProductsViewModel
            {
                Products = Products,
                sortCriteria = sortCriteria,
                ascDesc = ascDesc
            });
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
        public async Task<IActionResult> Info(string productId)
        {

            Product product = await _productRepository.GetAsync(productId);
                //_prodContext.Products
                //.Where(p => p.ProductId == productId)
                //.Include(a => a.Artist)
                //;
            
            return View(product);
        }
    }
}