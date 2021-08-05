using ArtWebshop.Models;
using ArtWebshop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IRepository<Product> _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IRepository<Product> productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public async Task<RedirectToActionResult> AddToShoppingCart(string productId)
        {
            
            Product product = await _productRepository.GetAsync(productId);
            
            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }

            return RedirectToAction();
        }
    }
}
