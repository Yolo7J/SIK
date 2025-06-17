using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Infrastructure.Data.Models
{
    public class RealEstateOwnership
    {
        public int RealEstateId { get; set; }
        public RealEstate RealEstate { get; set; } = null!;

        public int UserId { get; set; }
        public User Owner { get; set; } = null!;
        public double OwnershipPercentage { get; set; }
        public DateOnly DateAcquired { get; set; }
    }
}
