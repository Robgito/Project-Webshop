using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private WebshopDBContext _dbContext;
        public BrandRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BrandEntity> GetBrandByIDAsync(int id)
        {
            return await _dbContext.Brands
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<BrandEntity>> GetAllBrandsAsync()
        {
            return await _dbContext.Brands
                .ToArrayAsync();
        }

        public async Task AddBrandAsync(BrandEntity brandEntity)
        {
            await _dbContext.Brands
                .AddAsync(brandEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBrandAsync(int id)
        {
            BrandEntity brandEntity = new BrandEntity()
            {
                ID = id
            };

            _dbContext.Brands
                .Remove(brandEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBrandAsync(BrandEntity brandEntity)
        {
            _dbContext.Brands
                .Update(brandEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
