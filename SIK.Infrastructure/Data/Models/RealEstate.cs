using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SIK.Constants;

namespace SIK.Infrastructure.Data.Models
{
    public class RealEstate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RealEstateConstants.AddressMaxLength)]
        public string Adress { get; set; }
        = string.Empty;
        [Required]
        public double AreaInSqrMeters { get; set; }
        [Required]
        public int YearOfConstruction { get; set; }
        [ForeignKey(nameof(Owner))]
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public User Owner { get; set; } = null!;
        public decimal MarketPrice { get; set; }


    }
}
