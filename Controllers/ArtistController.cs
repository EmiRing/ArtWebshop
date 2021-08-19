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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ArtWebshop.Repositories;

namespace ArtWebshop.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ProductDbContext _productDbContext;
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRepository<Product> _productRepository;

        public ArtistController(ProductDbContext productDbContext, AppDbContext appDbContext, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IRepository<Product> productRepository)
        {
            _productDbContext = productDbContext;
            _appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _productRepository = productRepository;
        }

        //[Authorize(Roles = "Artist")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var artist = _productDbContext.Artist
                .FirstOrDefault(u => u.UserId == user.Id);

            return View(artist);
        }

        [HttpGet]
        public async Task<IActionResult> CreateArtist()
        {
            var user = await _userManager.GetUserAsync(User);

                if (!_productDbContext.Artist.Any(u => u.UserId == user.Id))
                {
                    Artist newArtist = new Artist
                    {
                        ArtistId = Guid.NewGuid().ToString(),
                        UserId = user.Id,
                        ArtistName = "Artist",
                        Presentation = "Presentation"
                    };

                    _productDbContext.Add(newArtist);
                    await _productDbContext.SaveChangesAsync();
                }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist(Artist artist)
        {
            var newArtist = _productDbContext.Artist.FirstOrDefault(u => u.ArtistId == artist.ArtistId);

            Artist artistModel = new Artist
            {
                ArtistName = artist.ArtistName,
                Presentation = artist.Presentation
            };
            await _productDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> EditArtist()
        {
            var user = await _userManager.GetUserAsync(User);
            var artist = _productDbContext.Artist
            .FirstOrDefault(u => u.UserId == user.Id);

            var myUser = await _userManager.FindByIdAsync(user.Id);
            return View(artist);
            
        }
       [HttpPost]
        public async Task<IActionResult> EditArtist(Artist artist)
        {
            var user = await _userManager.FindByIdAsync(artist.ArtistId);

            artist.ArtistId = artist.ArtistId;
            artist.ArtistName = artist.ArtistName;
            artist.ProfilePicture = artist.ProfilePicture;
            artist.Presentation = artist.Presentation;

            _productDbContext.Artist.Update(artist);
            await _productDbContext.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}
