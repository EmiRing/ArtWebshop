using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ArtWebshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductDbContext _productContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductsController(ProductDbContext context, UserManager<ApplicationUser> userManager)
        {
            _productContext = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string id)
        {
            ArtistProductViewModel artistProdViewModel = new ArtistProductViewModel();
            var user = await _userManager.GetUserAsync(User);

            
            artistProdViewModel.Products = await _productContext.Products
                .OrderBy(d => d.CreationDate)
                .Where(p => p.ArtistId == id)
                .Include(a => a.Artist)
                .ToListAsync();

            return View(artistProdViewModel);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            //var user = await _userManager.GetUserAsync(User);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var myUser = await _userManager.GetUserAsync(User);

            Artist artist = _productContext.Artist.FirstOrDefault(u => u.UserId == myUser.Id);

            if (ModelState.IsValid)
            {
                Product newProduct = new Product
                {
                    ProductId = Guid.NewGuid().ToString(),
                    ArtistId = artist.ArtistId,
                    Title = product.Title,
                    Width = product.Width,
                    Height = product.Height,
                    ShortDescription = product.ShortDescription,
                    LongDescription = product.LongDescription,
                    Category = product.Category,
                    Style = product.Style,
                    CreationDate = product.CreationDate,
                    Price = product.Price,
                    Stock = product.Stock,

                };
                _productContext.Add(newProduct);

                await _productContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> MakePublic(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productContext.Products
                .Include(p => p.Artist)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("MakePublic")]
        public async Task<IActionResult> MakePublicConfirmed(string id)
        {
            ArtistProductViewModel artistProdViewModel = new ArtistProductViewModel();
            artistProdViewModel.Products = await _productContext.Products
                .Include(a => a.Artist)
                .ToListAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_productContext.Artist, "ArtistId", "ArtistId", product.ArtistId);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeProduct(string id, [Bind("ProductId,Title,Width,Height,ShortDescription,LongDescription,Category,Style,CreationDate,Price,PictureLink,ThumbnailLink,ArtistId,IsPaintingOfTheWeek,Stock")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _productContext.Update(product);
                    await _productContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

            }
            ViewData["ArtistId"] = new SelectList(_productContext.Artist, "ArtistId", "ArtistId", product.ArtistId);
            return View(product);
        }


        public async Task<IActionResult> DeleteProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productContext.Products
                .Include(p => p.Artist)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _productContext.Products.FindAsync(id);
            _productContext.Products.Remove(product);
            await _productContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _productContext.Products.Any(e => e.ProductId == id);
        }

        public IActionResult ListProducts()
        {
            return View(_productContext.Products.ToList());
        }
    }
}
