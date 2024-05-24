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
    public class BrandController : ControllerBase
    {
        private IBrandService _brandService;
        private IMapper _mapper;

        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
        }

        [HttpGet]
        
        public async Task<ActionResult> GetSpecificBrandAsync(int id)
        {
            Brand brand = await _brandService.GetBrandAsync(id);
            BrandDTO brandDTO = _mapper.Map<BrandDTO>(brand);

            if (brand == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(brandDTO);
            }
        }

        [HttpGet]
        [Route("GetAllBrands")]
        public async Task<ActionResult<BrandDTO>> GetAllBrandsAsync()
        {
            IEnumerable<Brand> brands = await _brandService.GetAllBrandsAsync();
            IEnumerable<BrandDTO> brandDTOs = _mapper.Map<IEnumerable<BrandDTO>>(brands);

            if (brands == null || brands.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(brandDTOs);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddBrandAsync(AddBrandDTO addBrandDTO)
        {
            if (ModelState.IsValid)
            {
                Brand brand = _mapper.Map<Brand>(addBrandDTO);
                await _brandService.AddBrandAsync(brand);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBrandAsync(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateBrandAsync(int id, UpdateBrandDTO updateBrandDTO)
        {
            if (ModelState.IsValid)
            {
                Brand brand = _mapper.Map<Brand>(updateBrandDTO);

                await _brandService.UpdateBrandAsync(id, brand);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
