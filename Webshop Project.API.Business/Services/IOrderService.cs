using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface IOrderService
    {
        Task<Order> GenerateOrderAsync(int userID);

        Task DeleteOrderAsync(int id);

        void FinalizeOrder(Order order);

        Task<IEnumerable<Order>> GetAllOrderAsync();

        Task<Order> GetOrderAsync(int id);

        Task UpdateOrderAsync(int id, Order order);
    }
}