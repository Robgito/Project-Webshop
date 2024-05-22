using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private WebshopDBContext _dbContext;
        public ProductRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SmartphoneEntity> GetSmartphoneByIDAsync(int id)
        {
            return await _dbContext.Smartphones
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<SmartphoneEntity>> GetAllSmartphonesAsync()
        {
            return await _dbContext.Smartphones
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .ToArrayAsync();
        }

        public async Task AddSmartphoneAsync(SmartphoneEntity smartphoneEntity)
        {
            await _dbContext.Smartphones
                .AddAsync(smartphoneEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSmartphoneByIDAsync(int id)
        {
            SmartphoneEntity smartphoneEntity = new SmartphoneEntity()
            {
                ID = id
            };
            _dbContext.Smartphones
                .Remove(smartphoneEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSmartphoneAsync(SmartphoneEntity smartphoneEntity)
        {
            _dbContext.Smartphones
                .Update(smartphoneEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
