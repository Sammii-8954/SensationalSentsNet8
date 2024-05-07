using AutoMapper;
using SensationalScentsWeb.Data;
using SensationalScentsWeb.Models;

namespace SensationalScentsWeb.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<ProductType, ProductTypeVM>().ReverseMap();

        }
    }
}
