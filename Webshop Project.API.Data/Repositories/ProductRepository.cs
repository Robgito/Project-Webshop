using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class ProductRepository : GenericRepo<SmartphoneEntity>, IProductRepository
    {
        private WebshopDBContext _dbContext;
        public ProductRepository(WebshopDBContext dbContext) : base(dbContext)
        {

        }

        public async Task<SmartphoneEntity> GetSmartphoneByIDAsync(int id)
        {
            return await _dbContext.Smartphones
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<SmartphoneEntity>> GetAllSmartphonesAsync()
        {
            return await _dbContext.Smartphones
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .ToArrayAsync();
        }
    }
}
