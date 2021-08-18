using ArtWebshop.Models;
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
            
            if (items == null) return NoContent();

            return View(new ShoppingCartViewModel {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        [HttpGet]
        public IActionResult GetVueData()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (items == null) return NotFound();


            var cartModel = new ShoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return Ok(cartModel);
        }
        
        public async Task<RedirectToActionResult> AddToShoppingCart(string productId, string sortCriteria, string ascDesc) 
        {
            //string productId = prodId.ToString();
            Product product = await _productRepository.GetAsync(productId);
            
            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }

            return RedirectToAction("Index", "ProductTemp", new { sortCriteria, ascDesc});
        }
        
        public async Task<RedirectToActionResult> AddToCart(string productId)
        {
            //string productId = prodId.ToString();
            Product product = await _productRepository.GetAsync(productId);

            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }

            return RedirectToAction("Info", "ProductTemp", new { productId = productId});
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

        [HttpPost]
        public async Task<IActionResult> ChangeAmount([FromBody] postData postData)
        {

            string itemId = postData.itemId;
            string check = postData.check;
            var item = _shoppingCart.GetShoppingCartItems().FirstOrDefault(i => i.Product.ProductId == itemId);
            Product product = await _productRepository.GetAsync(item.Product.ProductId);
            switch (check)
            {
                case "add":
                    _shoppingCart.IncreaseAmountInCart(product);
                    break;
                case "reduce":
                    _shoppingCart.ReduceAmountInCart(product);
                    break;
                case "remove":
                    _shoppingCart.RemoveFromCart(product);
                    break;
                default:
                    break;
            }

            return Json(new { Success = true });
        }



    }
}
