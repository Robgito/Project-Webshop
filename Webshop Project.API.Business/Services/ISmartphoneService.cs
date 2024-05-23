using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface ISmartphoneService
    {
        Task AddSmartphoneAsync(Smartphone smartphone);
        Task DeleteSmartphoneAsync(int id);
        Task<Smartphone> GetSmartphoneAsync(int id);
        Task<IEnumerable<Smartphone>> GetSmartphonesAsync();
        Task UpdateSmartphoneAsync(int id, Smartphone smartphone);
    }
}