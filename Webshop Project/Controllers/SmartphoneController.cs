using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.DTO;

namespace Webshop_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartphoneController : ControllerBase
    {
        private ISmartphoneService _smartphoneService;
        private IMapper _mapper;

        public SmartphoneController(ISmartphoneService smartphoneService, IMapper mapper)
        {
            _smartphoneService = smartphoneService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<SmartphoneDTO>> GetSpecificSmartphoneAsync(int id)
        {
            Smartphone smartphone = await _smartphoneService.GetSmartphoneAsync(id);
            SmartphoneDTO smartphoneDTO = _mapper.Map<SmartphoneDTO>(smartphone);

            if (smartphone == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(smartphoneDTO);
            }
        }

        [HttpGet]
        [Route("GetAllSmartphones")]
        public async Task<ActionResult<SmartphoneDTO>> GetAllSmartphonesAsync(int? enterBrandID, int? enterCategoryID, int? enterMemoryCapacity, int? enterMinPrice, int? enterMaxPrice, int page = 1, int items = 20)
        {
            IEnumerable<Smartphone> smartphones = await _smartphoneService.GetSmartphonesAsync(page, items, enterBrandID, enterCategoryID, enterMemoryCapacity, enterMinPrice, enterMaxPrice);
            IEnumerable<SmartphoneDTO> smartphoneDTOs = _mapper.Map<IEnumerable<SmartphoneDTO>>(smartphones);

            if (smartphones == null || smartphones.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(smartphoneDTOs);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddSmartphoneAsync(AddSmartphoneDTO addSmartphone)
        {
            if (ModelState.IsValid)
            {
                Smartphone smartphone = _mapper.Map<Smartphone>(addSmartphone);
                await _smartphoneService.AddSmartphoneAsync(smartphone);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteSmartphoneAsync(int id)
        {
            await _smartphoneService.DeleteSmartphoneAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateSmartphoneAsync(int id, UpdateSmartphoneDTO updateSmartphone)
        {
            if (ModelState.IsValid)
            {
                Smartphone smartphone = _mapper.Map<Smartphone>(updateSmartphone);
                await _smartphoneService.UpdateSmartphoneAsync(id, smartphone);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
