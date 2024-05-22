using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IProductRepository
    {
        Task AddSmartphoneAsync(SmartphoneEntity smartphoneEntity);
        Task DeleteSmartphoneByIDAsync(int id);
        Task<IEnumerable<SmartphoneEntity>> GetAllSmartphonesAsync();
        Task<SmartphoneEntity> GetSmartphoneByIDAsync(int id);
        Task UpdateSmartphoneAsync(SmartphoneEntity smartphoneEntity);
    }
}