using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IBasketRepository _basketRepository;
        private IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IBasketRepository basketRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _basketRepository = basketRepository;
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

        public async Task<Order> GenerateOrderAsync(int basketID)
        {
            List<SmartphoneEntity> smartphonesInCart = await _basketRepository.GetProductsInBasket(basketID);

            double totalPrice = smartphonesInCart.Sum(x => x.Price);
            double shippingPrice = 25;

            // TODO: Complete method
            Order order = new Order
            {
                TotalPrice = totalPrice + shippingPrice,
            };

            return order;
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

        public void FinalizeOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}