using ArtWebshop.Data;
using ArtWebshop.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ShoppingCart
    {
        private readonly ProductDbContext _productDbContext;
        private List<Product> _products;

        public string ShoppingCartId { get; set; }

        public ShoppingCart(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ProductDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product)
        {
            if(SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "ShoppingCartItems") != null)

        }
    }
}
