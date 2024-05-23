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
    }
}
