using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IProductRepository : IGenericRepo<SmartphoneEntity>
    {
        Task<IEnumerable<SmartphoneEntity>> GetAllItemAsync(int skip, int take, int? enterBrandID, int? enterCategoryID, int? enterMemoryCapacity, int? enterMinPrice, int? enterMaxPrice, string? userSearch);

        Task<SmartphoneEntity> GetItemByIDAsync(int id);
    }
}