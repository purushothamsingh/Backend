using System.ComponentModel.DataAnnotations;

namespace RealEstateAPI.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public int LastUpdatedBy { get; set; }
    }
}
