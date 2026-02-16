using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeedingExample.Models
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CityName { get; set; }

        public int StateId { get; set; } // Foreign Key

        // Navigation Property
        public State State { get; set; }
    }
}