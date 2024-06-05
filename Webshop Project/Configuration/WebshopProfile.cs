using AutoMapper;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.DTO;

namespace Webshop_Project.Configuration
{
    public class WebshopProfile : Profile
    {
        public WebshopProfile()
        {
            CreateMap<Smartphone, SmartphoneEntity>().ReverseMap();
            CreateMap<Smartphone, SmartphoneDTO>()
                .ForMember(x => x.Brand, y => y.MapFrom(z => z.Brand.Name))
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category.Name));
            CreateMap<AddSmartphoneDTO, Smartphone>();
            CreateMap<UpdateSmartphoneDTO, Smartphone>();

            CreateMap<Category, CategoryEntity>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<AddCategoryDTO, Category>();
            CreateMap<UpdateCategoryDTO, Category>();

            CreateMap<Brand, BrandEntity>().ReverseMap();
            CreateMap<Brand, BrandDTO>().ReverseMap();
            CreateMap<AddBrandDTO, Brand>();
            CreateMap<UpdateBrandDTO, Brand>();

            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<AddUserDTO, User>();
            CreateMap<UpdateUserDTO, User>();

            CreateMap<Basket, BasketEntity>().ReverseMap();
            CreateMap<Basket, BasketDTO>().ReverseMap();
            CreateMap<AddBasketDTO, Basket>();
            CreateMap<UpdateBasketDTO, Basket>();

            CreateMap<BasketProduct, BasketProductEntity>().ReverseMap();
            CreateMap<BasketProduct, BasketProductDTO>().ReverseMap();
            CreateMap<BasketProductDTO, BasketProductEntity>().ReverseMap();

            CreateMap<AddBasketProductDTO, BasketProduct>();

            CreateMap<BasketProduct, SmartphoneDTO>()
                .ForMember(x => x.Brand, y => y.MapFrom(z => z.Product.Brand.Name))
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Product.Category.Name))
                .ForMember(x => x.Colour, y => y.MapFrom(z => z.Product.Colour))
                .ForMember(x => x.Price, y => y.MapFrom(z => z.Product.Price))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Product.Name))
                .ForMember(x => x.Image, y => y.MapFrom(z => z.Product.Image))
                .ForMember(x => x.Image, y => y.MapFrom(z => z.Product.Image))
                .ForMember(x => x.Stock, y => y.MapFrom(z => z.Product.Stock))
                .ForMember(x => x.MemoryCapacity, y => y.MapFrom(z => z.Product.MemoryCapacity))
                .ForMember(x => x.ScreenSize, y => y.MapFrom(z => z.Product.ScreenSize))
                .ForMember(x => x.Description, y => y.MapFrom(z => z.Product.Description));
        }
    }
}