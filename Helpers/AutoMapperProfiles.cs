using AutoMapper;
using RealEstateAPI.Dtos;
using RealEstateAPI.Models;

namespace RealEstateAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<City, CityUpdateDto>().ReverseMap();
        }
    }
}
