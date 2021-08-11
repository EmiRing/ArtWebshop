﻿using ArtWebshop.Data;
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

        public async Task<IActionResult> Index()
        {
            ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
            artProdViewModel.Product = await _prodContext.Products
                .OrderBy(p => p.Title)
                .Include(a => a.Artist)
                .ToListAsync();

            return View(artProdViewModel);
        }
    }
}