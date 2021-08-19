using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.Repositories;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<ApplicationUser> _userRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ProductDbContext _productDbContext;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, UserManager<ApplicationUser> userManager, IRepository<ApplicationUser> userRepository, SignInManager<ApplicationUser> signInManager, ProductDbContext productDbContext)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _userManager = userManager;
            _userRepository = userRepository;
            _signInManager = signInManager;
            _productDbContext = productDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var order = new Order();
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                order = new Order()
                {
                    UserId = user.Id,
                    DeliveryFirstName = user.FirstName,
                    DeliveryLastName = user.LastName,
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

            //var checkout = new CheckoutViewModel
            //{
            //    order = order,
            //};

            return View(order);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {

            if (_signInManager.IsSignedIn(User))
            {
                var userId = _userManager.GetUserId(User);
                order.UserId = userId;
            }

            if (!ModelState.IsValid)
            {
                order = new Order();
                return View(order);
            }

            await _orderRepository.CreateOrder(order);
            _shoppingCart.ClearCart();

            return RedirectToAction("CheckoutSummary", new { orderId = order.OrderId });
        }

        [HttpGet]
        public async Task<IActionResult> CheckoutSummary(int orderId)
        {
            var order = await _productDbContext.Orders.Include(x => x.OrderRows).ThenInclude(x => x.Product).FirstOrDefaultAsync(o => o.OrderId == orderId);
            
            return View(order);
        }
    }
}
