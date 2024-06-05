using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface IBasketService
    {
        Task AddBasketAsync(Basket basket);

        Task DeleteBasketAsync(int id);

        Task<IEnumerable<Basket>> GetAllBasketAsync();

        Task<Basket> GetBasketAsync(int id);

        int SaveNewBasketID();

        Task UpdateBasketAsync(int id, Basket basket);

        Task AddBasketProductAsync(BasketProduct basketProduct);

        Task<List<Smartphone>> GetAllProductsInBasketAsync(int basketID);

        Task<List<BasketProduct>> GetAllBasketProductsInBasketAsync(int basketID);

        Task DeleteBasketProductAsync(int id);
    }
}