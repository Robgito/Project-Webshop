using AutoMapper;
using Moq;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;
using Webshop_Project.Configuration;

namespace Webshop.Project.Tests
{
    public class OrderTests
    {
        [Fact]
        public async Task WhenPlacingAnOrder_TotalPriceIsCalculatedCorrectly()
        {
            //Arrange
            double expectedPrice = 325;

            var basket = new List<SmartphoneEntity>()
            {
             new SmartphoneEntity { Price = 100 },
             new SmartphoneEntity { Price = 200 },
            };

            IMapper _mapper = new MapperConfiguration(mc => mc.AddProfile(new WebshopProfile())).CreateMapper();

            var orderRepo = new Mock<IOrderRepository>();
            var basketRepo = new Mock<IBasketRepository>();

            basketRepo
             .Setup(x => x.GetProductsInBasket(It.IsAny<int>()))
             .ReturnsAsync(basket);

            OrderService orderService = new OrderService(orderRepo.Object, basketRepo.Object, _mapper);

            //Act
            Order result = await orderService.GenerateOrderAsync(1);

            //Assert
            Assert.Equal(result.TotalPrice, expectedPrice);
        }
    }
}