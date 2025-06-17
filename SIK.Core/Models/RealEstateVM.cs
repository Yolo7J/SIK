using SIK.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class RealEstateVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RealEstateConstants.AddressMaxLength)]
        public string Adress { get; set; } = string.Empty;
        [Required]
        public double AreaInSqrMeters { get; set; }
        [Required]
        public int YearOfConstruction { get; set; }
        [Required]
        public decimal MarketPrice { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public List<RealEstateOwnershipVM> Owners { get; set; } = new();
    }
}
