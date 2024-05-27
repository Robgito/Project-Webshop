using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IBasketRepository : IGenericRepo<BasketEntity>
    {
        Task AddBasketAsync(BasketEntity basketEntity);
        Task<BasketEntity> GetBasketWithProductsByIDAsync(int id);
        int ReturnNewBasketID();
        void SaveNewBasketID(int ID);
    }
}