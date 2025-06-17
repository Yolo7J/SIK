using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using SIK.Constants;

namespace SIK.Infrastructure.Data.Models
{
    public class User : IdentityUser
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
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
        public string? ProfilePictureUrl { get; set; } = null;
        [Required]
        public bool IsDeleated { get; set; } = false;
        public List<RealEstateOwnership> OwnedProperties { get; set; } = new List<RealEstateOwnership>();
    }
}
