using SIK.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Core.Models
{
    public class UserVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(UserConstants.NameMinLength)]
        [MaxLength(UserConstants.NameMaxLength)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MinLength(UserConstants.NameMinLength)]
        [MaxLength(UserConstants.NameMaxLength)]
        public string MiddleName { get; set; } = string.Empty;
        [Required]
        [MinLength(UserConstants.NameMinLength)]
        [MaxLength(UserConstants.NameMaxLength)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public List<RealEstateOwnershipVM> OwnedProperties { get; set; } = new List<RealEstateOwnershipVM>();
        public List<TransportAssetVM> TransportAssets { get; set; } = new List<TransportAssetVM>();
        public List<ServiceVM> Services { get; set; } = new List<ServiceVM>();
    }
}
