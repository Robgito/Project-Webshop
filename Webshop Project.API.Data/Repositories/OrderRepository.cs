using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class OrderRepository : GenericRepo<OrderEntity>, IOrderRepository
    {
        public OrderRepository(WebshopDBContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<OrderEntity>> GetAllItemAsync()
        {
            return await _dbContext.Orders
                .Include(x => x.ListProducts)
                .ToArrayAsync();
        }

    }
}
