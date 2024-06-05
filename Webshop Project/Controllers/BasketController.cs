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

        [HttpGet]
        [Route("GetAllProductsInBasket")]
        public async Task<ActionResult<SmartphoneDTO>> GetAllProductsInBasketAsync(int basketID)
        {
            IEnumerable<BasketProduct> basketProducts = await _basketService.GetAllBasketProductsInBasketAsync(basketID);
            IEnumerable<SmartphoneDTO> smartphoneDTOs = _mapper.Map<IEnumerable<SmartphoneDTO>>(basketProducts);

            if (basketProducts == null || basketProducts.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(smartphoneDTOs);
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
        public async Task<ActionResult> AddBasketProductAsync(AddBasketProductDTO addBasketProductDTO)
        {
            if (ModelState.IsValid)
            {
                BasketProduct basketProduct = _mapper.Map<BasketProduct>(addBasketProductDTO);
                await _basketService.AddBasketProductAsync(basketProduct);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("DeleteBasketProduct")]
        public async Task<ActionResult> DeleteBasketProductAsync(int id)
        {
            await _basketService.DeleteBasketProductAsync(id);
            return Created();
        }

        [HttpGet]
        [Route("GetBasketProductByProductAndBasketID")]
        public async Task<ActionResult<BasketProductDTO>> GetBasketProductByProductIDAndBasketID(int productID, int basketID)
        {
            BasketProduct basketProduct = await _basketService.GetBasketProductByBasketAndProductIDAsync(productID, basketID);
            BasketProductDTO basketProductDTO = _mapper.Map<BasketProductDTO>(basketProduct);

            if (basketProduct == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(basketProductDTO);
            }
        }

        [HttpPatch]
        [Route("AddAmountToBasketProduct")]
        public async Task<ActionResult> AddAmountToBasketProduct(int id)
        {
            await _basketService.AddAmountInBasketByID(id);
            return Created();
        }

        [HttpPatch]
        [Route("DecreaseAmountToBasketProduct")]
        public async Task<ActionResult> DecreaseAmountToBasketProduct(int id)
        {
            await _basketService.DecreaseAmountInBasketByID(id);
            return Created();
        }
    }
}