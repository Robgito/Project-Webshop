using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(Category category);

        Task DeleteCategoryAsync(int id);

        Task<IEnumerable<Category>> GetAllCategoriesAsync();

        Task<Category> GetCategoryAsync(int id);

        Task UpdateCategoryAsync(int id, Category category);
    }
}