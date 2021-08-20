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
    public class AdminController : Controller
    {
        private readonly IRepository<ApplicationUser> _userRepository;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ProductDbContext _productDbContext;

        public AdminController(IRepository<ApplicationUser> userRepository, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ProductDbContext productDbContext)
        {
            _userRepository = userRepository;
            _roleManager = roleManager;
            _userManager = userManager;
            _productDbContext = productDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ListUsers()
        {
            var users = await _userManager.Users.OrderBy(u => u.FirstName).ToListAsync();

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{id}'");
            }

            var hasRoles = await _userManager.GetRolesAsync(user);

            return View(new UserViewModel { 
                User = user,
                Roles = hasRoles
            });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserViewModel model)
        {
            var id = model.User.Id;
            
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.FirstName = model.User.FirstName;
                user.LastName = model.User.LastName;
                user.Email = model.User.Email;
                
                var hasRole = await _userManager.GetRolesAsync(user);
                var availableRoles = _roleManager.Roles.ToList();
                foreach (var role in availableRoles)
                {
                    if (hasRole.Contains(role.Name) && !model.Roles.Contains(role.Name))
                    {
                        await _userManager.RemoveFromRoleAsync(user, role.Name);
                    }
                    else if(!hasRole.Contains(role.Name) && model.Roles.Contains(role.Name))
                    {
                        await _userManager.AddToRoleAsync(user, role.Name);
                    }
                }
                
                if (model.Password != null && model.Password != "")
                {
                    var passwordValidator = new PasswordValidator<ApplicationUser>();
                    var pV = await passwordValidator.ValidateAsync(_userManager, user, model.Password);
                    if (pV.Succeeded)
                    {
                        PasswordHasher<ApplicationUser> pH = new PasswordHasher<ApplicationUser>();
                        user.PasswordHash = pH.HashPassword(user, model.Password);
                    }
                    else
                    {
                        Errors(pV);
                        return View(model);
                    }
                }


                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("ListUsers", "Admin");
                else
                    Errors(result);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ListOrders()
        {
            //List<Order> orders = _productDbContext.Orders.Include(r => r.OrderRows).ThenInclude(p => p.Product).ToList();
            List<Order> orders = _productDbContext.Orders.ToList();
            return View(orders);
        }

        public IActionResult UpdateOrder(int orderId)
        {
            Order order = _productDbContext.Orders.Include(r => r.OrderRows).ThenInclude(p => p.Product).FirstOrDefault(o => o.OrderId == orderId);
            return View(order);
        }
        private void Errors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
