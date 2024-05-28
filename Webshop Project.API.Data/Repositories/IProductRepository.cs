using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IProductRepository : IGenericRepo<SmartphoneEntity>
    {
        Task<IEnumerable<SmartphoneEntity>> GetAllItemAsync();
        Task<SmartphoneEntity> GetItemByIDAsync(int id);
    }
}