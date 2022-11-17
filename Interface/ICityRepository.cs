using RealEstateAPI.Dtos;
using RealEstateAPI.Models;

namespace RealEstateAPI.Interface
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        void AddCity(City city);
        void DeleteCity(int cityId); 
        int UpdateCity(int id,CityDto citydto);
        //Task<City> FindCity(int id);

    }
}
