using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class SmartphoneService : ISmartphoneService
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public SmartphoneService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Smartphone> GetSmartphoneAsync(int id)
        {
            Smartphone smartphone = new Smartphone();
            SmartphoneEntity smartphoneEntity = await _productRepository.GetSmartphoneByIDAsync(id);

            if (smartphoneEntity == null)
            {
                return null;
            }

            smartphone = _mapper.Map<Smartphone>(smartphoneEntity);
            return smartphone;
        }

        public async Task<IEnumerable<Smartphone>> GetSmartphonesAsync()
        {
            List<Smartphone> smartphones = new List<Smartphone>();
            IEnumerable<SmartphoneEntity> smartphoneEntities = await _productRepository.GetAllSmartphonesAsync();

            smartphones = _mapper.Map<List<Smartphone>>(smartphoneEntities);
            return smartphones;
        }

        public async Task AddSmartphoneAsync(Smartphone smartphone)
        {
            SmartphoneEntity smartphoneEntity = _mapper.Map<SmartphoneEntity>(smartphone);
            smartphoneEntity.Created = DateTime.Now;
            smartphoneEntity.Updated = DateTime.Now;
            await _productRepository.AddSmartphoneAsync(smartphoneEntity);
        }

        public async Task DeleteSmartphoneAsync(int id)
        {
            await _productRepository.DeleteSmartphoneByIDAsync(id);
        }

        public async Task UpdateSmartphoneAsync(int id, Smartphone smartphone)
        {
            SmartphoneEntity smartphoneEntity = await _productRepository.GetSmartphoneByIDAsync(id);

            SmartphoneEntity updateSmartphoneEntity = _mapper.Map<SmartphoneEntity>(smartphone);

            smartphoneEntity.Name = updateSmartphoneEntity.Name;
            smartphoneEntity.Description = updateSmartphoneEntity.Description;
            smartphoneEntity.Price = updateSmartphoneEntity.Price;
            smartphoneEntity.Image = updateSmartphoneEntity.Image;
            smartphoneEntity.Stock = updateSmartphoneEntity.Stock;
            smartphoneEntity.MemoryCapacity = updateSmartphoneEntity.MemoryCapacity;
            smartphoneEntity.Colour = updateSmartphoneEntity.Colour;
            smartphoneEntity.ScreenSize = updateSmartphoneEntity.ScreenSize;
            smartphoneEntity.BrandID = updateSmartphoneEntity.BrandID;
            smartphoneEntity.CategoryID = updateSmartphoneEntity.CategoryID;
            smartphoneEntity.Updated = DateTime.Now;

            await _productRepository.UpdateSmartphoneAsync(smartphoneEntity);
        }
    }
}
