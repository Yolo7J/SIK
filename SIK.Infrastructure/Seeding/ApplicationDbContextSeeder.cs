using Microsoft.EntityFrameworkCore;
using SIK.Constants;
using SIK.Constants.Enums;
using SIK.Infrastructure.Data.Common;
using SIK.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public static void SeedTransportAssets(ModelBuilder builder)
        {
            var transportAssets = new List<TransportAsset>
                {
                    new TransportAsset
                    {
                        Id = 1,
                        Type = Vehicles.Car,
                        YearOfManufacture = 2018,
                        Name = "Toyota Camry",
                        Description = "Reliable sedan with great fuel economy",
                        OwnerId = 2, // John Doe
                        Price = 22000.00m,
                        ImageUrl = null
                    },
                    new TransportAsset
                    {
                        Id = 2,
                        Type = Vehicles.Motorcycle,
                        YearOfManufacture = 2020,
                        Name = "Harley-Davidson Sportster",
                        Description = "Classic American cruiser motorcycle",
                        OwnerId = 3, // Jane Smith
                        Price = 12500.00m,
                        ImageUrl = null
                    },
                    new TransportAsset
                    {
                        Id = 3,
                        Type = Vehicles.Boat,
                        YearOfManufacture = 2015,
                        Name = "Sea Ray Sundancer",
                        Description = "24-foot luxury bowrider",
                        OwnerId = 4, // Robert Johnson
                        Price = 45000.00m,
                        ImageUrl = null
                    },
                    new TransportAsset
                    {
                        Id = 4,
                        Type = Vehicles.Truck,
                        YearOfManufacture = 2019,
                        Name = "Ford F-150",
                        Description = "Full-size pickup truck, 4WD",
                        OwnerId = 5, // Emily Wilson
                        Price = 35000.00m,
                        ImageUrl = null
                    },
                    new TransportAsset
                    {
                        Id = 5,
                        Type = Vehicles.Car,
                        YearOfManufacture = 2021,
                        Name = "Tesla Model 3",
                        Description = "Electric vehicle with autopilot",
                        OwnerId = 6, // Michael Brown
                        Price = 48000.00m,
                        ImageUrl = null
                    }
                };

            builder.Entity<TransportAsset>().HasData(transportAssets);
        }
        public static void SeedServices(ModelBuilder builder)
        {
            var services = new List<Service>
    {
        // Insurance services for transport assets
        new Service
        {
            Id = 1,
            PricePerMonth = 120.00m,
            Description = "Comprehensive auto insurance",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-12)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now.AddMonths(-1)),
            SignatoryId = 2, // John Doe (owns Toyota Camry)
            TransportAssetId = 1, // Toyota Camry
            ServiceType = ServiceType.Insurance
        },
        new Service
        {
            Id = 2,
            PricePerMonth = 85.00m,
            Description = "Motorcycle full coverage",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now),
            SignatoryId = 3, // Jane Smith (owns Harley)
            TransportAssetId = 2, // Harley-Davidson
            ServiceType = ServiceType.Insurance
        },
        
        // Security services for transport assets
        new Service
        {
            Id = 3,
            PricePerMonth = 45.00m,
            Description = "GPS tracking system subscription",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-3)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now),
            SignatoryId = 4, // Robert Johnson (owns boat)
            TransportAssetId = 3, // Sea Ray Sundancer
            ServiceType = ServiceType.Security
        },
        
        // Insurance for real estate (assuming you'll add real estate later)
       // Updated real estate services
        new Service
        {
            Id = 4,
            PricePerMonth = 250.00m,
            Description = "Property damage insurance for Sofia apartment",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-24)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now.AddMonths(-3)),
            SignatoryId = 5, // Emily Wilson
            RealEstateId = 1, // Sofia property
            ServiceType = ServiceType.Insurance
        },
        new Service
        {
            Id = 5,
            PricePerMonth = 180.00m,
            Description = "Security system for Varna beach house",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-18)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)),
            SignatoryId = 6, // Michael Brown
            RealEstateId = 2, // Varna property
            ServiceType = ServiceType.Security
        },
        // Additional services for other properties
        new Service
        {
            Id = 6,
            PricePerMonth = 150.00m,
            Description = "Ski chalet insurance in Bansko",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-12)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now),
            SignatoryId = 7, // Sarah Davis
            RealEstateId = 3, // Bansko property
            ServiceType = ServiceType.Insurance
        },
        new Service
        {
            Id = 7,
            PricePerMonth = 200.00m,
            Description = "Plovdiv city center property security",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-9)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now),
            SignatoryId = 8, // David Miller
            RealEstateId = 4, // Plovdiv property
            ServiceType = ServiceType.Security
        },
        new Service
        {
            Id = 8,
            PricePerMonth = 175.00m,
            Description = "Ruse riverside apartment insurance",
            Signed = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6)),
            LastChanged = DateOnly.FromDateTime(DateTime.Now),
            SignatoryId = 9, // Lisa Moore
            RealEstateId = 5, // Ruse property
            ServiceType = ServiceType.Insurance
        }

    };

            builder.Entity<Service>().HasData(services);
        }
        public static void SeedRealEstates(ModelBuilder builder)
        {
            var realEstates = new List<RealEstate>
    {
        new RealEstate
        {
            Id = 1,
            Adress = "123 Main Street, Sofia, Bulgaria",
            AreaInSqrMeters = 120.5,
            YearOfConstruction = 2010,
            MarketPrice = 250000.00m,
            ImageUrl = null
        },
        new RealEstate
        {
            Id = 2,
            Adress = "45 Coastal Road, Varna, Bulgaria",
            AreaInSqrMeters = 95.0,
            YearOfConstruction = 2018,
            MarketPrice = 320000.00m,
            ImageUrl = null
        },
        new RealEstate
        {
            Id = 3,
            Adress = "7 Mountain View, Bansko, Bulgaria",
            AreaInSqrMeters = 85.0,
            YearOfConstruction = 2005,
            MarketPrice = 180000.00m,
            ImageUrl = null
        },
        new RealEstate
        {
            Id = 4,
            Adress = "22 Central Square, Plovdiv, Bulgaria",
            AreaInSqrMeters = 150.0,
            YearOfConstruction = 2015,
            MarketPrice = 290000.00m,
            ImageUrl = null
        },
        new RealEstate
        {
            Id = 5,
            Adress = "15 Riverside, Ruse, Bulgaria",
            AreaInSqrMeters = 110.0,
            YearOfConstruction = 2020,
            MarketPrice = 210000.00m,
            ImageUrl = null
        }
    };

            builder.Entity<RealEstate>().HasData(realEstates);
        }
        public static void SeedRealEstateOwnerships(ModelBuilder builder)
        {
            var ownerships = new List<RealEstateOwnership>
    {
        // Sofia property (ID 1) owned by Emily Wilson (ID 5) who has insurance service
        new RealEstateOwnership
        {
            Id = 1,
            RealEstateId = 1,
            UserId = 5,
            OwnershipPercentage = 100.0,
            DateAcquired = DateOnly.FromDateTime(DateTime.Now.AddYears(-2))
        },
        // Varna property (ID 2) owned by Michael Brown (ID 6) who has security service
        new RealEstateOwnership
        {
            Id = 2,
            RealEstateId = 2,
            UserId = 6,
            OwnershipPercentage = 100.0,
            DateAcquired = DateOnly.FromDateTime(DateTime.Now.AddYears(-1).AddMonths(-6))
        },
        // Bansko property (ID 3) owned by Sarah Davis (ID 7) who has insurance service
        new RealEstateOwnership
        {
            Id = 3,
            RealEstateId = 3,
            UserId = 7,
            OwnershipPercentage = 100.0,
            DateAcquired = DateOnly.FromDateTime(DateTime.Now.AddYears(-1))
        },
        // Plovdiv property (ID 4) owned by David Miller (ID 8) who has security service
        new RealEstateOwnership
        {
            Id = 4,
            RealEstateId = 4,
            UserId = 8,
            OwnershipPercentage = 100.0,
            DateAcquired = DateOnly.FromDateTime(DateTime.Now.AddMonths(-9))
        },
        // Ruse property (ID 5) owned by Lisa Moore (ID 9) who has insurance service
        new RealEstateOwnership
        {
            Id = 5,
            RealEstateId = 5,
            UserId = 9,
            OwnershipPercentage = 100.0,
            DateAcquired = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6))
        }
    };

            builder.Entity<RealEstateOwnership>().HasData(ownerships);
        }
    }
}
