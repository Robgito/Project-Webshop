using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface ISmartphoneService
    {
        Task AddSmartphoneAsync(Smartphone smartphone);
        Task DeleteSmartphoneAsync(int id);
        Task<Smartphone> GetSmartphoneAsync(int id);
        Task<IEnumerable<Smartphone>> GetSmartphonesAsync(int page, int take, int? enterBrandID, int? enterCategoryID, int? enterMemoryCapacity, int? enterMinPrice, int? enterMaxPrice);
        Task UpdateSmartphoneAsync(int id, Smartphone smartphone);
    }
}