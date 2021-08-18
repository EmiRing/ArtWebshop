using ArtWebshop.Models;
using ArtWebshop.Repositories;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<ApplicationUser> _userRepository;

        public OrderController(IRepository<Order> orderRepository, ShoppingCart shoppingCart, UserManager<ApplicationUser> userManager, IRepository<ApplicationUser> userRepository)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _userManager = userManager;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userRepository.GetAsync(userId);
            var order = new Order();
            if (user != null)
            {
                order = new Order()
                {
                    UserId = user.Id,
                    DeliveryStreetName = user.DeliveryStreetName,
                    DeliveryCity = user.DeliveryCity,
                    DeliveryPostalCode = user.DeliveryPostalCode,
                    DeliveryCountry = user.DeliveryCountry
                };
                if (user.BillingStreetName != null && user.BillingCity != null && user.BillingPostalCode != null && user.BillingCountry != null)
                {
                    order.BillingStreetName = user.BillingStreetName;
                    order.BillingCity = user.BillingCity;
                    order.BillingPostalCode = user.BillingPostalCode;
                    order.BillingCountry = user.BillingCountry;
                }
            }
            
            
            var checkout = new CheckoutViewModel
            {
                order = order,
                shoppingCart = _shoppingCart
            };

            return View(checkout);


        }
    }
}
