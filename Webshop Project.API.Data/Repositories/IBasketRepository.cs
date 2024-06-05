using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IBasketRepository : IGenericRepo<BasketEntity>
    {
        Task AddBasketAsync(BasketEntity basketEntity);

        Task AddBasketProductAsync(BasketProductEntity basketProductEntity);

        Task<BasketEntity> GetBasketWithProductsByIDAsync(int id);

        Task<List<SmartphoneEntity>> GetProductsInBasket(int basketID);

        int ReturnNewBasketID();

        void SaveNewBasketID(int ID);

        Task<List<BasketProductEntity>> GetBasketProductsInBasket(int basketID);

        Task<List<BasketProductEntity>> GetAllBasketProductsAsync();

        Task UpdateBasketProductAsync(BasketProductEntity basketProductEntity);

        Task<BasketProductEntity> GetBasketProductByBasketAndProductIDAsync(int productID, int basketID);
    }
}