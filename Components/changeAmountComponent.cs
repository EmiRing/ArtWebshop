using ArtWebshop.Helpers;
using ArtWebshop.Models;
using ArtWebshop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Components
{
    public class changeAmountComponent: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IRepository<Product> _productRepository;

        public changeAmountComponent(ShoppingCart shoppingCart, IRepository<Product> productRepository)
        {
            _shoppingCart = shoppingCart;
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync(string itemId, string action = "neither")
        {
            var item = _shoppingCart.GetShoppingCartItems().FirstOrDefault(i => i.Product.ProductId == itemId);
            Product product = await _productRepository.GetAsync(item.Product.ProductId);
            switch (action)
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

            return View();
        }
    }
}
