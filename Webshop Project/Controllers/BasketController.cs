using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private IBasketService _basketService;
        private IMapper _mapper;

        public BasketController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetSpecificBasketAsync(int id)
        {
            Basket basket = await _basketService.GetBasketAsync(id);
            BasketDTO basketDTO = _mapper.Map<BasketDTO>(basket);

            if (basket == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(basketDTO);
            }
        }

        [HttpGet]
        [Route("GetAllBaskets")]
        public async Task<ActionResult<BasketDTO>> GetAllBasketsAsync()
        {
            IEnumerable<Basket> baskets = await _basketService.GetAllBasketAsync();
            IEnumerable<BasketDTO> basketDTOs = _mapper.Map<IEnumerable<BasketDTO>>(baskets);

            if (baskets == null || baskets.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(basketDTOs);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddBasketAsync(AddBasketDTO addBasketDTO)
        {
            if (ModelState.IsValid)
            {
                Basket basket = _mapper.Map<Basket>(addBasketDTO);
                await _basketService.AddBasketAsync(basket);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBasketAsync(int id)
        {
            await _basketService.DeleteBasketAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateBasketAsync(int id, UpdateBasketDTO updateBasketDTO)
        {
            if (ModelState.IsValid)
            {
                Basket basket = _mapper.Map<Basket>(updateBasketDTO);

                await _basketService.UpdateBasketAsync(id, basket);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [Route("AddBasketProduct")]
        public async Task<ActionResult> AddBasketProductAsync(BasketProductDTO basketProductDTO)
        {
            if (ModelState.IsValid)
            {
                BasketProduct basketProduct = _mapper.Map<BasketProduct>(basketProductDTO);
                await _basketService.AddBasketProductAsync(basketProduct);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}