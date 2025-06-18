using Microsoft.EntityFrameworkCore;
using SIK.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Infrastructure.Seeding
{
    public class ApplicationDbContextSeeder
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            var users = new List<User>
    {
        new User
        {
            Id = 1,
            UserName = "admin@example.com",
            Email = "admin@example.com",
            FirstName = "Admin",
            MiddleName = "System",
            LastName = "User",
            DateOfBirth = new DateTime(1980, 1, 1),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false,
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        },
        new User
        {
            Id = 2,
            UserName = "john.doe@example.com",
            Email = "john.doe@example.com",
            FirstName = "John",
            MiddleName = "Michael",
            LastName = "Doe",
            DateOfBirth = new DateTime(1990, 5, 15),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 3,
            UserName = "jane.smith@example.com",
            Email = "jane.smith@example.com",
            FirstName = "Jane",
            MiddleName = "Elizabeth",
            LastName = "Smith",
            DateOfBirth = new DateTime(1985, 8, 22),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        // Add 7 more users following the same pattern
        new User
        {
            Id = 4,
            UserName = "robert.johnson@example.com",
            Email = "robert.johnson@example.com",
            FirstName = "Robert",
            MiddleName = "Lee",
            LastName = "Johnson",
            DateOfBirth = new DateTime(1978, 3, 10),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 5,
            UserName = "emily.wilson@example.com",
            Email = "emily.wilson@example.com",
            FirstName = "Emily",
            MiddleName = "Grace",
            LastName = "Wilson",
            DateOfBirth = new DateTime(1992, 11, 5),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 6,
            UserName = "michael.brown@example.com",
            Email = "michael.brown@example.com",
            FirstName = "Michael",
            MiddleName = "James",
            LastName = "Brown",
            DateOfBirth = new DateTime(1987, 7, 19),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 7,
            UserName = "sarah.davis@example.com",
            Email = "sarah.davis@example.com",
            FirstName = "Sarah",
            MiddleName = "Anne",
            LastName = "Davis",
            DateOfBirth = new DateTime(1995, 4, 30),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 8,
            UserName = "david.miller@example.com",
            Email = "david.miller@example.com",
            FirstName = "David",
            MiddleName = "Paul",
            LastName = "Miller",
            DateOfBirth = new DateTime(1983, 9, 12),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 9,
            UserName = "lisa.moore@example.com",
            Email = "lisa.moore@example.com",
            FirstName = "Lisa",
            MiddleName = "Marie",
            LastName = "Moore",
            DateOfBirth = new DateTime(1991, 2, 25),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        },
        new User
        {
            Id = 10,
            UserName = "james.taylor@example.com",
            Email = "james.taylor@example.com",
            FirstName = "James",
            MiddleName = "William",
            LastName = "Taylor",
            DateOfBirth = new DateTime(1975, 6, 8),
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            ProfilePictureUrl = null,
            IsDeleated = false
        }
    };

            builder.Entity<User>().HasData(users);
        }
    }
}
