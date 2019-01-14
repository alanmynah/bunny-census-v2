using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Bunnies")]
    public class Bunny
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Residence { get; set; }
        [Required]
        [StringLength(255)]
        public string Colour { get; set; } 
    }
}