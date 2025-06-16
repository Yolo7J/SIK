using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIK.Infrastructure.Data.Models
{
    public class RealEstate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        = string.Empty;
        [Required]
        public double AreaInSqrMeters { get; set; }
        [Required]
        public int YearOfConstruction { get; set; }
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        public User Owner { get; set; } = null!;


    }
}
