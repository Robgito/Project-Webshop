using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            CategoryEntity categoryEntity = await _categoryRepository.GetCategoryByIDAsync(id);

            if (categoryEntity == null)
            {
                return null;
            }

            Category category = _mapper.Map<Category>(categoryEntity);
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            IEnumerable<CategoryEntity> categoryEntities = await _categoryRepository.GetAllCategoriesAsync();
            IEnumerable<Category> categories = _mapper.Map<IEnumerable<Category>>(categoryEntities);
            return categories;
        }

        public async Task AddCategoryAsync(Category category)
        {
            CategoryEntity categoryEntity = _mapper.Map<CategoryEntity>(category);
            categoryEntity.Created = DateTime.Now;
            categoryEntity.Updated = DateTime.Now;

            await _categoryRepository.AddCategoryAsync(categoryEntity);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _categoryRepository.DeleteCategoryByIDAsync(id);
        }

        public async Task UpdateCategoryAsync(int id, Category category)
        {
            CategoryEntity categoryDB = await _categoryRepository.GetCategoryByIDAsync(id);

            CategoryEntity updatecategoryEntity = _mapper.Map<CategoryEntity>(category);

            categoryDB.Name = updatecategoryEntity.Name;
            categoryDB.Updated = DateTime.Now;

            await _categoryRepository.UpdateCategoryAsync(categoryDB);
        }
    }
}
