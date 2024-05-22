using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(CategoryEntity categoryEntity);
        Task DeleteCategoryByIDAsync(int id);
        Task<IEnumerable<CategoryEntity>> GetAllCategoriesAsync();
        Task<CategoryEntity> GetCategoryByIDAsync(int id);
        Task UpdateCategoryAsync(CategoryEntity categoryEntity);
    }
}