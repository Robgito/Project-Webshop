using AutoMapper;
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
            await _basketRepository.DeleteItemByIDAsync(basketEntity);
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

        public int SaveNewBasketID()
        {
            return _basketRepository.ReturnNewBasketID();
        }
    }
}
