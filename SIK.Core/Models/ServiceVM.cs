using SIK.Constants.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class ServiceVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal PricePerMonth { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public DateOnly Signed { get; set; }
        [Required]
        public DateOnly LastChanged { get; set; }
        [Required]

        public int SignatoryId { get; set; }
        public string SignatoryFullName { get; set; } = string.Empty; // e.g. FirstName + LastName

        public int? RealEstateId { get; set; }
        public string? RealEstateAddress { get; set; } // from RealEstate.Adress

        public int? TransportAssetId { get; set; }
        public string? TransportAssetName { get; set; } // from TransportAsset.Name
        [Required]
        public ServiceType ServiceType { get; set; }
        public string ServiceTypeName => ServiceType.ToString();
    }
}
