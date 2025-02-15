﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<List<SmartphoneEntity>> GetProductsInBasket(int basketID)
        {
            return await _dbContext.BasketProducts
                .Include(x => x.Product)
                .Where(x => x.BasketID == basketID)
                .Select(x => x.Product)
                .ToListAsync();
        }

        public async Task<List<BasketProductEntity>> GetBasketProductsInBasket(int basketID)
        {
            return await _dbContext.BasketProducts
                .Include(x => x.Product)
                .Where(x => x.BasketID == basketID)
                .ToListAsync();
        }

        public async Task<List<BasketProductEntity>> GetAllBasketProductsAsync()
        {
            return await _dbContext.BasketProducts
                .ToListAsync();
        }

        public async Task UpdateBasketProductAsync(BasketProductEntity basketProductEntity)
        {
            _dbContext.BasketProducts.Update(basketProductEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBasketProductAsync(BasketProductEntity basketProductEntity)
        {
            _dbContext.BasketProducts
                .Remove(basketProductEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<BasketProductEntity> GetBasketProductByBasketAndProductIDAsync(int productID, int basketID)
        {
            return await _dbContext.BasketProducts
                .Where(x => x.BasketID == basketID)
                .Where(x => x.ProductID == productID)
                .SingleOrDefaultAsync();
        }

        public async Task<BasketProductEntity> GetBasketProductByID(int basketProductID)
        {
            return await _dbContext.BasketProducts
                .Where(x => x.ID == basketProductID)
                .SingleOrDefaultAsync();
        }
    }
}