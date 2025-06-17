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
        [Required]
        public List<RealEstateOwnership> Owners { get; set; } = new List<RealEstateOwnership>();
        [Required]
        public decimal MarketPrice { get; set; }
        public string? ImageUrl { get; set; } = null;

    }
}
