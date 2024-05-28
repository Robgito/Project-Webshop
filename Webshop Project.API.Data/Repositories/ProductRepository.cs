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

        public override async Task<IEnumerable<SmartphoneEntity>> GetAllItemAsync()
        {
            return await _dbContext.Smartphones
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .ToArrayAsync();
        }
    }
}
