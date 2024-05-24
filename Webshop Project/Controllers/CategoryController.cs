using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.DTO;

namespace Webshop_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCategory")]
        public async Task<ActionResult> GetSpecificCategotryAsync(int id)
        {
            Category category = await _categoryService.GetCategoryAsync(id);
            CategoryDTO categoryDTO = _mapper.Map<CategoryDTO>(category);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(categoryDTO);
            }
        }

        [HttpGet]
        [Route("GetAllCategories")]
        public async Task<ActionResult<CategoryDTO>> GetAllCategoriesAsync()
        {
            IEnumerable<Category> categories = await _categoryService.GetAllCategoriesAsync();
            IEnumerable<CategoryDTO> categoryDTOs = _mapper.Map<IEnumerable<CategoryDTO>>(categories);

            if (categories == null || categories.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(categoryDTOs);
            }
        }

        [HttpPost]
        [Route("AddCategory")]
        public async Task<ActionResult> AddCategoryAsync(AddCategoryDTO addCategoryDTO)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<Category>(addCategoryDTO);
                await _categoryService.AddCategoryAsync(category);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public async Task<ActionResult> DeleteCategoryAsync(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Created();
        }

        [HttpPut]
        [Route("UpdateCategory")]
        public async Task<ActionResult> UpdateCategoryAsync(int id, UpdateCategoryDTO updateCategoryDTO)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<Category>(updateCategoryDTO);

                await _categoryService.UpdateCategoryAsync(id, category);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
