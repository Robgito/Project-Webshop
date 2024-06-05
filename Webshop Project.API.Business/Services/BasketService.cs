using AutoMapper;
using System.Collections.Generic;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class BasketService : IBasketService
    {
        private IBasketRepository _basketRepository;
        private IMapper _mapper;

        public BasketService(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<Basket> GetBasketAsync(int id)
        {
            BasketEntity basketEntity = await _basketRepository.GetBasketWithProductsByIDAsync(id);

            if (basketEntity == null)
            {
                return null;
            }

            Basket basket = _mapper.Map<Basket>(basketEntity);
            await AddPriceAndShippingToBasket(basket);
            return basket;
        }

        public async Task<IEnumerable<Basket>> GetAllBasketAsync()
        {
            IEnumerable<BasketEntity> basketEntities = await _basketRepository.GetAllItemAsync();
            IEnumerable<Basket> baskets = _mapper.Map<IEnumerable<Basket>>(basketEntities);
            return baskets;
        }

        public async Task AddBasketAsync(Basket basket)
        {
            BasketEntity basketEntity = _mapper.Map<BasketEntity>(basket);
            basketEntity.Created = DateTime.Now;
            basketEntity.Updated = DateTime.Now;

            await _basketRepository.AddBasketAsync(basketEntity);
        }

        public async Task DeleteBasketAsync(int id)
        {
            BasketEntity basketEntity = new BasketEntity()
            {
                ID = id
            };
            await _basketRepository.DeleteItemAsync(basketEntity);
        }

        public async Task UpdateBasketAsync(int id, Basket basket)
        {
            BasketEntity basketDB = await _basketRepository.GetBasketWithProductsByIDAsync(id);

            BasketEntity updateBasketEntity = _mapper.Map<BasketEntity>(basket);

            basketDB.Updated = DateTime.Now;
            basketDB.ShippingPrice = updateBasketEntity.ShippingPrice;
            basketDB.ListProducts = updateBasketEntity.ListProducts;

            await _basketRepository.UpdateItemAsync(basketDB);
        }

        public async Task AddBasketProductAsync(BasketProduct basketProduct)
        {
            List<BasketProductEntity> basketProductEntities = await _basketRepository.GetAllBasketProductsAsync();
            BasketProductEntity basketProductEntity = _mapper.Map<BasketProductEntity>(basketProduct);

            if (CheckIfProductIsAlreadyInBasket(basketProductEntities, basketProductEntity))
            {
                basketProductEntity = await UpdateAmountInBasket(basketProduct, basketProductEntity);
            }
            else
            {
                await AddToBasket(basketProductEntity);
            }
        }

        private async Task AddToBasket(BasketProductEntity basketProductEntity)
        {
            basketProductEntity.Created = DateTime.Now;
            basketProductEntity.Updated = DateTime.Now;

            await _basketRepository.AddBasketProductAsync(basketProductEntity);
        }

        private async Task<BasketProductEntity> UpdateAmountInBasket(BasketProduct basketProduct, BasketProductEntity basketProductEntity)
        {
            basketProductEntity = await _basketRepository.GetBasketProductByBasketAndProductIDAsync(basketProduct.ProductID, basketProduct.BasketID);

            basketProductEntity.Amount++;
            basketProductEntity.Updated = DateTime.Now;

            await _basketRepository.UpdateBasketProductAsync(basketProductEntity);
            return basketProductEntity;
        }

        public async Task<List<Smartphone>> GetAllProductsInBasketAsync(int basketID)
        {
            List<SmartphoneEntity> smartphoneEntities = await _basketRepository.GetProductsInBasket(basketID);
            List<Smartphone> smartphones = _mapper.Map<List<Smartphone>>(smartphoneEntities);

            return smartphones;
        }

        public async Task<List<BasketProduct>> GetAllBasketProductsInBasketAsync(int basketID)
        {
            List<BasketProductEntity> basketProductEntities = await _basketRepository.GetBasketProductsInBasket(basketID);
            List<BasketProduct> basketProducts = _mapper.Map<List<BasketProduct>>(basketProductEntities);

            return basketProducts;
        }

        public int SaveNewBasketID()
        {
            return _basketRepository.ReturnNewBasketID();
        }

        public bool CheckIfProductIsAlreadyInBasket(List<BasketProductEntity> basketProducts, BasketProductEntity product)
        {
            bool isInBasket = false;

            foreach (BasketProductEntity basketProduct in basketProducts)
            {
                if (product.ProductID == basketProduct.ProductID && product.BasketID == basketProduct.BasketID)
                {
                    isInBasket = true;
                    break;
                }
            }

            return isInBasket;
        }

        public async Task AddPriceAndShippingToBasket(Basket basket)
        {
            List<BasketProductEntity> BasketProductEntities = await _basketRepository.GetBasketProductsInBasket(basket.ID);

            basket.TotalPrice = BasketProductEntities.Sum(x => x.Product.Price * x.Amount);

            if (basket.TotalPrice >= 700)
            {
                basket.ShippingPrice = 0;
            }
            else
            {
                basket.ShippingPrice = 25;
            }

            basket.ExpectedShippingDate = DateTime.Now.AddDays(2);
        }

        public async Task DeleteBasketProductAsync(int id)
        {
            BasketProductEntity basketProductEntity = new BasketProductEntity()
            {
                ID = id
            };

            await _basketRepository.DeleteBasketProductAsync(basketProductEntity);
        }
    }
}