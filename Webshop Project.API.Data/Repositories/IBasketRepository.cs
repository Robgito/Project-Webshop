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
    }
}