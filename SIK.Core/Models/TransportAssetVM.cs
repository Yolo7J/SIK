using SIK.Constants;
using SIK.Constants.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class TransportAssetVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Vehicles Type { get; set; }
        public string TypeName => Type.ToString();
        [Required]
        [Range(TransportAssetConstants.YearOfManufactureMin, TransportAssetConstants.YearOfManufactureMax)]
        public int YearOfManufacture { get; set; }
        [Required]
        [MinLength(TransportAssetConstants.NameMinLength)]
        [MaxLength(TransportAssetConstants.NameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(TransportAssetConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public int OwnerId { get; set; }
        public string OwnerFullName { get; set; } = string.Empty; // e.g. FirstName + LastName
        [Required]
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
