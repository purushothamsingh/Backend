using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Models;

namespace RealEstateAPI.Data
{
    public class DataContext : DbContext
    {
        private readonly DataContext db;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<City> Cities { get; set; }
       
    }
}
