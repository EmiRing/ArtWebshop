using ArtWebshop.Data;
using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public class OrderRepository: Repository<Order>
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;


        public OrderRepository(ProductDbContext context,ShoppingCart shoppingCart, AppDbContext appDbContext) :base(context)
        {
            _shoppingCart = shoppingCart;
            _appDbContext = appDbContext;
        }

        public override Order Update(Order entity)
        {
            var order = _productContext.Orders.Single(o => o.OrderId == entity.OrderId);

            order.UserId = entity.UserId;
            order.OrderDate = entity.OrderDate;
            order.CouponId = entity.CouponId;

            order.OrderRows = entity.OrderRows;

            order.BillingStreetName = entity.BillingStreetName;
            order.BillingCity = entity.BillingCity;
            order.BillingPostalCode = entity.BillingPostalCode;
            order.BillingCountry = entity.BillingCountry;

            order.DeliveryStreetName = entity.DeliveryStreetName;
            order.DeliveryCity = entity.DeliveryCity;
            order.DeliveryPostalCode = entity.DeliveryPostalCode;
            order.DeliveryCountry = entity.DeliveryCountry;
            
            return base.Update(order);
        }

        public async Task CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderRows = new List<OrderRow>();

            foreach (var cartItem in shoppingCartItems)
            {
                var orderRow = new OrderRow()
                {
                    Amount = cartItem.Amount,
                    Price = cartItem.Product.Price,
                    ProductId = cartItem.Product.ProductId
                };
                order.OrderRows.Add(orderRow);
            }

            await _productContext.Orders.AddAsync(order);
            await _productContext.SaveChangesAsync();
        }
    }
}
