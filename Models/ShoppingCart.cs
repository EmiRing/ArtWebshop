using ArtWebshop.Data;
using ArtWebshop.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ShoppingCart
    {
        private readonly ProductDbContext _productDbContext;
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        
        public ISession _session;

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

            return new ShoppingCart(context) { ShoppingCartId = cartId, _session = session };
        }

        public void AddToCart(Product product)
        {
            var items = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(_session, "ShoppingCartItems");
            ShoppingCartItem item = items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);

            if (item == null)
            {
                item = new ShoppingCartItem()
                {
                    Product = product,
                    Amount = 1,
                    ShoppingCartId = ShoppingCartId
                };
            }
            else
            {
                item.Amount++;
            }
            SessionHelper.SetObjectAsJson(_session, "ShoppingCartItems", item);


        }
    }
}
