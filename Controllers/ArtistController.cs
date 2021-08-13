using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult Index()
        {
            var productDbContext = _productDbContext.Artists.Include(p => p.ArtistRows);
            return View(productDbContext.ToList());
        }

        public IActionResult CreateArtist()
        {
            ViewData["ArtistId"] = new SelectList(_productDbContext.Products, "ArtistId", "ArtistId");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist(Artist artist)
        {
            if (ModelState.IsValid && !ArtistExists(artist.ArtistId))
            {
                artist.ArtistId = Guid.NewGuid().ToString();
                _productDbContext.Add(artist);

                await _productDbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditArtist()
        {
            ViewData["ArtistID"] = new SelectList(_productDbContext.Artists, "ArtistId", "ArtistId");
            return View();
        }

        [HttpPost, ActionName("EditArtist")]
        public async Task<IActionResult> EditArtistConfirmed(Artist artist)
        {
            if (ModelState.IsValid && ArtistExists(artist.ArtistId))
            {
                _productDbContext.Update(artist);
                await _productDbContext.SaveChangesAsync();
            }
            else
            {
                artist.ArtistId = Guid.NewGuid().ToString();
                _productDbContext.Add(artist);
                await _productDbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    

        private bool ArtistExists(string id)
        {
            return _productDbContext.Artists.Any(e => e.ArtistId == id);
        }
    }
}
