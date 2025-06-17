using SIK.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Infrastructure.Data.Common
{
    public interface IService
    {
        public int Id { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
        public DateOnly Signed { get; set; }
        public DateOnly LastChanged { get; set; }
        public User Signatory { get; set; }
        public int SignatoryId { get; set; }
        public RealEstate? RealEstate { get; set; }
        public int? RealEstateId { get; set; } // Nullable to allow for insurances not tied to a real estate
        public TransportAsset? TransportAsset { get; set; }
        public int? TransportAssetId { get; set; } // Nullable to allow for insurances not tied to a transport asset
    }
}
