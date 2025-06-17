using SIK.Constants.Enums;
using SIK.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Infrastructure.Data.Models
{
    public class Service : IService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal PricePerMonth { get; set; }
        [Required]
        public string Description { get; set; }
        = string.Empty;
        [Required]
        public DateOnly Signed { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [Required]
        public DateOnly LastChanged { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [Required]
        public User Signatory { get; set; }
        [Required]
        public int SignatoryId { get; set; }
        public RealEstate? RealEstate { get; set; }
        [ForeignKey(nameof(RealEstate))]
        public int? RealEstateId { get; set; }
        public TransportAsset? TransportAsset { get; set; }
        [ForeignKey(nameof(TransportAsset))]
        public int? TransportAssetId { get; set; }
        [Required]
        public ServiceType ServiceType { get; set; }
        [NotMapped]
        public string ServiceTypeName => ServiceType.ToString();
    }
}
