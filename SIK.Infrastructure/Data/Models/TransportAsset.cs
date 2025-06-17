using SIK.Constants.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SIK.Constants;

namespace SIK.Infrastructure.Data.Models
{
    public class TransportAsset
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Vehicles Type { get; set; }
        [NotMapped]
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
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        [Required]
        public User Owner { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
