using ArtWebshop.Data;
using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IRepository<Product> _productRepository;
        private readonly ProductDbContext _productContext;

        public OrderRepository(ProductDbContext productContext,ShoppingCart shoppingCart, IRepository<Product> productRepository)
        {
            _productContext = productContext;
            _shoppingCart = shoppingCart;
            _productRepository = productRepository;
            
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            return await _productContext.FindAsync<Order>(orderId);
        }

        public Order Update(Order entity)
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

        return _productContext.Update(order).Entity;
        }

        public async Task CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderRows = new List<OrderRow>();

            foreach (var cartItem in shoppingCartItems)
            {
                var item = await _productRepository.GetAsync(cartItem.Product.ProductId);
                if (item.Stock >= cartItem.Amount)
                {
                    item.Stock -= cartItem.Amount;

                    var orderRow = new OrderRow()
                    {
                        Amount = cartItem.Amount,
                        Price = cartItem.Product.Price,
                        ProductId = cartItem.Product.ProductId
                    };
                    order.OrderRows.Add(orderRow);
                    _productRepository.Update(item);
                }
            }

            await _productContext.Orders.AddAsync(order);
            await _productContext.SaveChangesAsync();
        }
    }
}
