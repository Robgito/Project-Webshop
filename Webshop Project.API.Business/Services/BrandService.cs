using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class BrandService : IBrandService
    {
        private IBrandRepository _brandRepository;
        private IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<Brand> GetBrandAsync(int id)
        {
            BrandEntity brandEntity = await _brandRepository.GetBrandByIDAsync(id);

            if (brandEntity == null)
            {
                return null;
            }

            Brand brand = _mapper.Map<Brand>(brandEntity);
            return brand;
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            IEnumerable<BrandEntity> brandEntities = await _brandRepository.GetAllBrandsAsync();
            IEnumerable<Brand> brands = _mapper.Map<IEnumerable<Brand>>(brandEntities);
            return brands;
        }

        public async Task AddBrandAsync(Brand brand)
        {
            BrandEntity brandEntity = _mapper.Map<BrandEntity>(brand);
            brandEntity.Created = DateTime.Now;
            brandEntity.Updated = DateTime.Now;

            await _brandRepository.AddBrandAsync(brandEntity);
        }

        public async Task DeleteBrandAsync(int id)
        {
            await _brandRepository.DeleteBrandAsync(id);
        }

        public async Task UpdateBrandAsync(int id, Brand brand)
        {
            BrandEntity brandDB = await _brandRepository.GetBrandByIDAsync(id);

            BrandEntity updatebrandEntity = _mapper.Map<BrandEntity>(brand);

            brandDB.Name = updatebrandEntity.Name;
            brandDB.Updated = DateTime.Now;

            await _brandRepository.UpdateBrandAsync(brandDB);
        }

    }
}
