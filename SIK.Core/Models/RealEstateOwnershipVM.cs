using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class RealEstateOwnershipVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RealEstateId { get; set; }
        [Required]
        public string RealEstateAddress { get; set; } = string.Empty;  // from RealEstate.Adress
        [Required]
        public int UserId { get; set; }
        [Required]
        public string OwnerFullName { get; set; } = string.Empty;      // e.g. FirstName + LastName
        [Required]
        public double OwnershipPercentage { get; set; }
        [Required]
        public DateOnly DateAcquired { get; set; }
    }
}
