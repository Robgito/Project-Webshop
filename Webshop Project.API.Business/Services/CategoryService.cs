using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private IGenericRepo<CategoryEntity> _categoryRepository;
        private IMapper _mapper;

        public CategoryService(IGenericRepo<CategoryEntity> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            CategoryEntity categoryEntity = await _categoryRepository.GetItemByIDAsync(id);

            if (categoryEntity == null)
            {
                return null;
            }

            Category category = _mapper.Map<Category>(categoryEntity);
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            IEnumerable<CategoryEntity> categoryEntities = await _categoryRepository.GetAllItemAsync();
            IEnumerable<Category> categories = _mapper.Map<IEnumerable<Category>>(categoryEntities);
            return categories;
        }

        public async Task AddCategoryAsync(Category category)
        {
            CategoryEntity categoryEntity = _mapper.Map<CategoryEntity>(category);
            categoryEntity.Created = DateTime.Now;
            categoryEntity.Updated = DateTime.Now;

            await _categoryRepository.AddItemAsync(categoryEntity);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            CategoryEntity categoryEntity = new CategoryEntity()
            {
                ID = id
            };
            await _categoryRepository.DeleteItemAsync(categoryEntity);
        }

        public async Task UpdateCategoryAsync(int id, Category category)
        {
            CategoryEntity categoryDB = await _categoryRepository.GetItemByIDAsync(id);

            CategoryEntity updatecategoryEntity = _mapper.Map<CategoryEntity>(category);

            categoryDB.Name = updatecategoryEntity.Name;
            categoryDB.Updated = DateTime.Now;

            await _categoryRepository.UpdateItemAsync(categoryDB);
        }
    }
}