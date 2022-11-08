using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Data;
using RealEstateAPI.Dtos;
using RealEstateAPI.Interface;
using RealEstateAPI.Models;

namespace RealEstateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DataContext db;
        private readonly ICityRepository repo;
        private readonly IMapper mapper;
        public CityController(ICityRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetCities()
        {
            var cities = await repo.GetCitiesAsync();
            var citiesDto = mapper.Map<IEnumerable<CityDto>>(cities);
            return Ok(citiesDto);
        }

        [HttpPost]

        public async Task<IActionResult> AddCity(CityDto cityDto)
        {
            var city = mapper.Map<City>(cityDto);
            city.LastUpdatedBy = 1;
            city.LastUpdatedOn = DateTime.Now;
            repo.AddCity(city);
            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            repo.DeleteCity(id);
            return Ok(id);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateCity(int id,CityDto citydto)
        {
            int flag = repo.UpdateCity(id,citydto);
            if(flag == 1)
            {
                return Ok();
            }
            return BadRequest("Update not allowed");
            

        }

    }
}
