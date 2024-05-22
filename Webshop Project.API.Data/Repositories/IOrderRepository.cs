using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(OrderEntity orderEntity);
        Task DeleteOrderByIDAsync(int id);
        Task<IEnumerable<OrderEntity>> GetAllOrdersAsync();
        Task<OrderEntity> GetOrderByIDAsync(int id);
        Task UpdateOrderAsync(OrderEntity orderEntity);
    }
}