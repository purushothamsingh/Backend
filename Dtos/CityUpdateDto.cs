using System.ComponentModel.DataAnnotations;

namespace RealEstateAPI.Dtos
{
    public class CityUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
