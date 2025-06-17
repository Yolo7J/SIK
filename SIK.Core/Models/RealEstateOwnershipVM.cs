using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class RealEstateOwnershipVM
    {
        public int RealEstateId { get; set; }
        public string RealEstateAddress { get; set; } = string.Empty;  // from RealEstate.Adress

        public int UserId { get; set; }
        public string OwnerFullName { get; set; } = string.Empty;      // e.g. FirstName + LastName

        public double OwnershipPercentage { get; set; }
        public DateOnly DateAcquired { get; set; }
    }
}
