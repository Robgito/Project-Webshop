using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class BasketRepository : GenericRepo<BasketEntity>, IBasketRepository
    {
        private int _newBasketID;

        public BasketRepository(WebshopDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<BasketEntity> GetBasketWithProductsByIDAsync(int id)
        {
            return await _dbContext.Basket
                .Include(x => x.ListProducts)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task AddBasketAsync(BasketEntity basketEntity)
        {
            await _dbContext.Basket
                .AddAsync(basketEntity);
            await _dbContext.SaveChangesAsync();
            SaveNewBasketID(basketEntity.ID);
        }

        public async Task AddBasketProductAsync(BasketProductEntity basketProductEntity)
        {
            await _dbContext.BasketProducts
                .AddAsync(basketProductEntity);
            await _dbContext.SaveChangesAsync();
        }

        public void SaveNewBasketID(int ID)
        {
            _newBasketID = ID;
        }

        public int ReturnNewBasketID()
        {
            return _newBasketID;
        }

        public virtual Task<List<SmartphoneEntity>> GetProductsInBasket(int basketID)
        {
            return _dbContext.BasketProducts
                .Include(x => x.Product)
                .Where(x => x.BasketID == basketID)
                .Select(x => x.Product)
                .ToListAsync();
        }
    }
}