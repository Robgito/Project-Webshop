using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface IOrderService
    {
        Task AddOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
        Task<IEnumerable<Order>> GetAllOrderAsync();
        Task<Order> GetOrderAsync(int id);
        Task UpdateOrderAsync(int id, Order order);
    }
}