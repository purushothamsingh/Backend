using RealEstateAPI.Models;

namespace RealEstateAPI.Interface
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        void AddCity(City city);
        void DeleteCity(int cityId);
        //Task<bool> SaveAsync();
    }
}
