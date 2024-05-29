using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.DTO;

namespace Webshop_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        private IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<OrderDTO>> GetSpecificOrderAsync(int id)
        {
            Order order = await _orderService.GetOrderAsync(id);
            OrderDTO orderDTO = _mapper.Map<OrderDTO>(order);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(orderDTO);
            }
        }

        [HttpGet]
        [Route("GetAllOrders")]
        public async Task<ActionResult<OrderDTO>> GetAllOrdersAsync()
        {
            IEnumerable<Order> orders = await _orderService.GetAllOrderAsync();
            IEnumerable<OrderDTO> orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(orders);

            if (orders == null || orders.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(orderDTOs);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddOrderAsync(AddOrderDTO addOrder)
        {
            if (ModelState.IsValid)
            {
                Order order = _mapper.Map<Order>(addOrder);
                await _orderService.AddOrderAsync(order);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteOrderAsync(int id)
        {
            await _orderService.DeleteOrderAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateOrderAsync(int id, UpdateOrderDTO updateOrder)
        {
            if (ModelState.IsValid)
            {
                Order order = _mapper.Map<Order>(updateOrder);
                await _orderService.UpdateOrderAsync(id, order);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
