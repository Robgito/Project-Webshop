using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Business.Services
{
    public interface IBasketService
    {
        Task AddBasketAsync(Basket basket);

        Task AddBasketProductAsync(BasketProduct basketProduct);

        Task AddPriceAndShippingToBasket(Basket basket);

        bool CheckIfProductIsAlreadyInBasket(List<BasketProductEntity> basketProducts, BasketProductEntity product);

        Task DeleteBasketAsync(int id);

        Task DeleteBasketProductAsync(int id);

        Task<IEnumerable<Basket>> GetAllBasketAsync();

        Task<List<BasketProduct>> GetAllBasketProductsInBasketAsync(int basketID);

        Task<List<Smartphone>> GetAllProductsInBasketAsync(int basketID);

        Task<Basket> GetBasketAsync(int id);

        Task<BasketProduct> GetBasketProductByBasketAndProductIDAsync(int productID, int basketID);

        int SaveNewBasketID();

        Task UpdateBasketAsync(int id, Basket basket);

        Task AddAmountInBasketByID(int basketProductID);

        Task DecreaseAmountInBasketByID(int basketProductID);
    }
}