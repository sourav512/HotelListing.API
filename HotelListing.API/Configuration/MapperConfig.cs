using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Model.Country;

namespace HotelListing.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() { 
            
            CreateMap<CreateCountryDto, Country>();
            CreateMap<Country, GetCountryDto>();
            CreateMap<Hotel,  GetHotelDto>();
            CreateMap<Country, GetCountryDetailDto>();
            CreateMap<UpdateCountryDto, Country>();
        }
    }
}
