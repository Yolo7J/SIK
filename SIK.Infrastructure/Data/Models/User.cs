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
        [StringLength(UserConstants.NameMaxLength, MinimumLength = UserConstants.NameMinLength)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(UserConstants.NameMaxLength, MinimumLength = UserConstants.NameMinLength)]
        public string MiddleName { get; set; } = string.Empty;
        [Required]
        [StringLength(UserConstants.NameMaxLength, MinimumLength = UserConstants.NameMinLength)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
