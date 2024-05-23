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
        }
    }
}
