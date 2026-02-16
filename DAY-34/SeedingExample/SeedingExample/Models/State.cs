using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SeedingExample.Models
{
    [Table("States")]
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        [MaxLength(100)]
        public string StateName { get; set; }

        public int CountryId { get; set; } // Foreign Key

        // Navigation Properties
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}