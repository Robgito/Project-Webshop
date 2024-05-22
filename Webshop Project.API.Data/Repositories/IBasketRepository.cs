﻿using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IBasketRepository
    {
        Task AddBasketAsync(BasketEntity basketEntity);
        Task DeleteBasketByIDAsync(int id);
        Task<IEnumerable<BasketEntity>> GetAllBasketAsync();
        Task<BasketEntity> GetBasketByIDAsync(int id);
        Task UpdateBasketAsync(BasketEntity basketEntity);
    }
}