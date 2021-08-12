﻿using ArtWebshop.Models;
using ArtWebshop.Repositories;
using ArtWebshop.ViewModels;
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
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            return View(new ShoppingCartViewModel {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        public async Task<RedirectToActionResult> AddToShoppingCart(string productId)
        {
            
            Product product = await _productRepository.GetAsync(productId);
            
            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }

            return RedirectToAction("ListProducts", "Products");
        }

        public async Task<IActionResult> ReduceAmount(string productId)
        {
            Product product = await _productRepository.GetAsync(productId);

            if (product != null)
            {
                _shoppingCart.ReduceAmountInCart(product);
            }

            return View("Index", new ShoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        public async Task<IActionResult> IncreaseAmount(string productId)
        {
            Product product = await _productRepository.GetAsync(productId);

            if (product != null)
            {
                _shoppingCart.IncreaseAmountInCart(product);
            }

            return View("Index", new ShoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        public async Task<IActionResult> RemoveFromCart(string productId)
        {
            Product product = await _productRepository.GetAsync(productId);

            if (product != null)
            {
                _shoppingCart.RemoveFromCart(product);
            }

            return View("Index", new ShoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        public async Task<IActionResult> ChangeAmount(string itemId, string check = "neither")
        {
            var item = _shoppingCart.GetShoppingCartItems().FirstOrDefault(i => i.Product.ProductId == itemId);
            Product product = await _productRepository.GetAsync(item.Product.ProductId);
            switch (check)
            {
                case "add":
                    _shoppingCart.IncreaseAmountInCart(product);
                    break;
                case "remove":
                    _shoppingCart.ReduceAmountInCart(product);
                    break;
                case "delete":

                    _shoppingCart.RemoveFromCart(product);

                    break;
                case "neither":

                    break;
                default:
                    break;
            }

            return Ok();
        }

       
    }
}
