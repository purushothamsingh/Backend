using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Interface;
using RealEstateAPI.Models;

namespace RealEstateAPI.Data.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext db;
        public CityRepository(DataContext _db)
        {
            db = _db;
        }
        public void AddCity(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
        }

        public void DeleteCity(int cityId)
        {
            var city = db.Cities.Find(cityId);
            db.Cities.Remove(city);
            db.SaveChanges();
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await db.Cities.ToListAsync();
        }

        //public async Task<bool> SaveAsync()
        //{
        //    return await db.SaveChangesAsync() > 0;
        //}
    }
}
