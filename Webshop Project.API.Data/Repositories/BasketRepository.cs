using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private WebshopDBContext _dbContext;
        public BasketRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BasketEntity> GetBasketByIDAsync(int id)
        {
            return await _dbContext.Basket
                .Include(x => x.ListProducts)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<BasketEntity>> GetAllBasketAsync()
        {
            return await _dbContext.Basket
                .ToArrayAsync();
        }

        public async Task AddBasketAsync(BasketEntity basketEntity)
        {
            await _dbContext.Basket
                .AddAsync(basketEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBasketByIDAsync(int id)
        {
            BasketEntity basketEntity = new BasketEntity()
            {
                ID = id
            };

            _dbContext.Basket
                .Remove(basketEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBasketAsync(BasketEntity basketEntity)
        {
            _dbContext.Basket
                .Update(basketEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
