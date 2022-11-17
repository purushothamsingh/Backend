using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Dtos;
using RealEstateAPI.Interface;
using RealEstateAPI.Models;

namespace RealEstateAPI.Data.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext db;
        private readonly IMapper mapper;
        public CityRepository(DataContext _db,IMapper _mapper)
        {
            db = _db;
            mapper = _mapper;
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

        //public async Task<City> FindCity(int id)
        //{
        //    return await db.Cities.FindAsync(id);
        //}

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await db.Cities.ToListAsync();
        }

        public int UpdateCity(int id, CityDto citydto)
        {
         

            var city = db.Cities.Find(id);

            if(city != null)
            {
                city.LastUpdatedBy = 1;
                city.LastUpdatedOn = DateTime.Now;
                mapper.Map(citydto, city);
                db.SaveChanges();
                return 1;   
            }
            return 0;

            
            

        }

    }
}
