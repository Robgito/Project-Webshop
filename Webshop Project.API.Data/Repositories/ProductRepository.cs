using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class ProductRepository : GenericRepo<SmartphoneEntity>, IProductRepository
    {
        public ProductRepository(WebshopDBContext dbContext) : base(dbContext)
        {

        }

        public override async Task<SmartphoneEntity> GetItemByIDAsync(int id)
        {
            return await _dbContext.Smartphones
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<SmartphoneEntity>> GetAllItemAsync(int skip, int take, int? enterBrandID, int? enterCategoryID, int? enterMemoryCapacity, int? enterMinPrice, int? enterMaxPrice)
        {
            return await _dbContext.Smartphones
                .Where(x => x.BrandID == enterBrandID || enterBrandID == null)
                .Where(x => x.CategoryID == enterCategoryID || enterCategoryID == null)
                .Where(x => x.MemoryCapacity >= enterMemoryCapacity || enterMemoryCapacity == null)
                .Where(x => (x.Price <= enterMaxPrice && x.Price >= enterMinPrice) || (enterMaxPrice == null && x.Price >= enterMinPrice) || (enterMinPrice == null && x.Price <= enterMaxPrice) || (enterMinPrice == null && enterMaxPrice == null))
                .Skip(skip)
                .Take(take)
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .OrderByDescending(x => x.ID)
                .ToArrayAsync();
        }
    }
}
