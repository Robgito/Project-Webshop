using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface ISmartphoneService
    {
        Task<Smartphone> GetSmartphoneAsync(int id);
        Task<IEnumerable<Smartphone>> GetSmartphonesAsync();
    }
}