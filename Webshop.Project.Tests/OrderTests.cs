using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            SmartphoneEntity smartphone1 = new SmartphoneEntity();
            smartphone1.Price = 100;

            SmartphoneEntity smartphone2 = new SmartphoneEntity();
            smartphone2.Price = 200;

            var basket = new List<SmartphoneEntity>() { smartphone1, smartphone2 };

            Mock<OrderRepository> orderRepository = new Mock<OrderRepository>();
            Mock<BasketRepository> basketRepository = new Mock<BasketRepository>();

            basketRepository.Setup(x => x.GetProductsInBasket(It.IsAny<int>()))
                .ReturnsAsync(basket);

            IMapper _mapper = new MapperConfiguration(mc => mc.AddProfile(new WebshopProfile())).CreateMapper();

            OrderService orderService = new OrderService(orderRepository.Object, basketRepository.Object, _mapper);

            //Act

            Order result = await orderService.GenerateOrderAsync(1);

            //Assert

            Assert.Equal(result.TotalPrice, expectedPrice);
        }

        [Fact]
        public void WhenPlacingAnOrderAbove500Euros_ThenShippingIsFree()
        {
            //Arrange
            double expectedPrice = 665.5;
            double expectedPriceWithShipping = 690.5;

            Order result = new Order();
            Smartphone smartphone1 = new Smartphone();
            smartphone1.Price = 350;

            Smartphone smartphone2 = new Smartphone();
            smartphone2.Price = 200;

            //Act

            //Assert

            Assert.Equal(result.TotalPrice, expectedPrice);
            Assert.NotEqual(result.TotalPrice, expectedPrice);
        }
    }
}