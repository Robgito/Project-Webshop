using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private WebshopDBContext _dbContext;
        public OrderRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderEntity> GetOrderByIDAsync(int id)
        {
            return await _dbContext.Orders
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<OrderEntity>> GetAllOrdersAsync()
        {
            return await _dbContext.Orders
                .Include(x => x.ListProducts)
                .ToArrayAsync();
        }

        public async Task AddOrderAsync(OrderEntity orderEntity)
        {
            await _dbContext.Orders
                .AddAsync(orderEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderByIDAsync(int id)
        {
            OrderEntity orderEntity = new OrderEntity()
            {
                ID = id
            };

            _dbContext.Orders
                .Remove(orderEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(OrderEntity orderEntity)
        {
            _dbContext.Orders
                .Update(orderEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
