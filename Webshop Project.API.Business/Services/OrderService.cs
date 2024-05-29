using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<Order> GetOrderAsync(int id)
        {
            OrderEntity orderEntity = await _orderRepository.GetItemByIDAsync(id);

            if (orderEntity == null)
            {
                return null;
            }

            Order order = _mapper.Map<Order>(orderEntity);
            return order;
        }

        public async Task<IEnumerable<Order>> GetAllOrderAsync()
        {
            IEnumerable<OrderEntity> orderEntities = await _orderRepository.GetAllItemAsync();
            IEnumerable<Order> orders = _mapper.Map<IEnumerable<Order>>(orderEntities);
            return orders;
        }

        public async Task AddOrderAsync(Order order)
        {
            OrderEntity orderEntity = _mapper.Map<OrderEntity>(order);
            orderEntity.Created = DateTime.Now;
            orderEntity.Updated = DateTime.Now;

            await _orderRepository.AddItemAsync(orderEntity);
        }

        public async Task DeleteOrderAsync(int id)
        {
            OrderEntity orderEntity = new OrderEntity()
            {
                ID = id
            };
            await _orderRepository.DeleteItemByIDAsync(orderEntity);
        }

        public async Task UpdateOrderAsync(int id, Order order)
        {
            OrderEntity orderDB = await _orderRepository.GetItemByIDAsync(id);
            OrderEntity updateOrderEntity = _mapper.Map<OrderEntity>(order);

            orderDB.Updated = DateTime.Now;
            orderDB.Street = updateOrderEntity.Street;
            orderDB.StreetNumber = updateOrderEntity.StreetNumber;
            orderDB.City = updateOrderEntity.City;
            orderDB.ListProducts = updateOrderEntity.ListProducts;

            await _orderRepository.UpdateItemAsync(orderDB);
        }
    }
}
