using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderAsync(int orderId);
        Order Update(Order order);
        Task CreateOrder(Order order);
    }
}
