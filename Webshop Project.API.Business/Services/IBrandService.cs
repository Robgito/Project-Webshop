using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface IBrandService
    {
        Task AddBrandAsync(Brand brand);

        Task DeleteBrandAsync(int id);

        Task<IEnumerable<Brand>> GetAllBrandsAsync();

        Task<Brand> GetBrandAsync(int id);

        Task UpdateBrandAsync(int id, Brand brand);
    }
}