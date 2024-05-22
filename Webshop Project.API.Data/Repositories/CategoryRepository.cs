using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private WebshopDBContext _dbContext;
        public CategoryRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CategoryEntity> GetCategoryByIDAsync(int id)
        {
            return await _dbContext.Categories
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<CategoryEntity>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories
                .ToArrayAsync();
        }

        public async Task AddCategoryAsync(CategoryEntity categoryEntity)
        {
            await _dbContext.Categories
                .AddAsync(categoryEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategoryByIDAsync(int id)
        {
            CategoryEntity categoryEntity = new CategoryEntity()
            {
                ID = id
            };

            _dbContext.Categories
                .Remove(categoryEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(CategoryEntity categoryEntity)
        {
            _dbContext.Categories
                .Update(categoryEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
