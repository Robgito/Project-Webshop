using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<SmartphoneEntity>> GetAllSmartphonesAsync();
        Task<SmartphoneEntity> GetSmartphoneByIDAsync(int id);
    }
}