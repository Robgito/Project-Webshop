using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IBrandRepository
    {
        Task AddBrandAsync(BrandEntity brandEntity);
        Task DeleteBrandAsync(int id);
        Task<IEnumerable<BrandEntity>> GetAllBrandsAsync();
        Task<BrandEntity> GetBrandByIDAsync(int id);
        Task UpdateBrandAsync(BrandEntity brandEntity);
    }
}