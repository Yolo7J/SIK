using System;
using System.Collections.Generic;
using System.Linq;

namespace SIK.Core.Models.Services
{
    using global::SIK.Infrastructure.Data.Common;
    using global::SIK.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    namespace SIK.Core.Services
    {
        public class UserService
        {
            private readonly Repository _repository;

            public UserService(Repository repository)
            {
                _repository = repository;
            }
            public async Task<UserVM?> GetByIdWithDetailsAsync(int id)
            {
                var user = await _repository.AllAsNoTrackingAsync<User>()
                    .Include(u => u.OwnedProperties)
                        .ThenInclude(op => op.RealEstate)
                    .Include(u => u.TransportAssets)
                    .Include(u => u.Services)
                        .ThenInclude(s => s.RealEstate)
                    .Include(u => u.Services)
                        .ThenInclude(s => s.TransportAsset)
                    .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleated);

                if (user == null)
                    return null;

                return new UserVM
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    ProfilePictureUrl = user.ProfilePictureUrl,

                    OwnedProperties = user.OwnedProperties.Select(op => new RealEstateOwnershipVM
                    {
                        RealEstateId = op.RealEstateId,
                        RealEstateAddress = op.RealEstate.Adress,
                        UserId = op.UserId,
                        OwnerFullName = $"{user.FirstName} {user.LastName}",
                        OwnershipPercentage = op.OwnershipPercentage,
                        DateAcquired = op.DateAcquired
                    }).ToList(),

                    TransportAssets = user.TransportAssets.Select(ta => new TransportAssetVM
                    {
                        Id = ta.Id,
                        Name = ta.Name,
                        Description = ta.Description,
                        ImageUrl = ta.ImageUrl,
                        OwnerId = ta.OwnerId,
                        Price = ta.Price,
                        Type = ta.Type,
                        YearOfManufacture = ta.YearOfManufacture
                    }).ToList(),

                    Services = user.Services.Select(s => new ServiceVM
                    {
                        Id = s.Id,
                        Description = s.Description,
                        PricePerMonth = s.PricePerMonth,
                        Signed = s.Signed,
                        LastChanged = s.LastChanged,
                        SignatoryId = s.SignatoryId,
                        RealEstateId = s.RealEstateId,
                        TransportAssetId = s.TransportAssetId,
                        ServiceType = s.ServiceType

                        // You can conditionally map the RealEstate/TransportAsset if needed
                    }).ToList()
                };
            }


            public async Task<List<UserVM>> GetAllAsync()
            {
                return await _repository.AllAsNoTrackingAsync<User>()
                    .Where(u => !u.IsDeleated)
                    .Select(u => new UserVM
                    {
                        Id = u.Id,
                        FirstName = u.FirstName,
                        MiddleName = u.MiddleName,
                        LastName = u.LastName,
                        DateOfBirth = u.DateOfBirth,
                        ProfilePictureUrl = u.ProfilePictureUrl
                    })
                    .ToListAsync();
            }

            public async Task<UserVM?> GetByIdAsync(int id)
            {
                try
                {
                    var entity = await _repository.GetByIdAsync<User>(id.ToString());
                    return new UserVM
                    {
                        Id = entity.Id,
                        FirstName = entity.FirstName,
                        MiddleName = entity.MiddleName,
                        LastName = entity.LastName,
                        DateOfBirth = entity.DateOfBirth,
                        ProfilePictureUrl = entity.ProfilePictureUrl
                    };
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }

            public async Task<int> CreateAsync(UserVM model)
            {
                var entity = new User
                {
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    ProfilePictureUrl = model.ProfilePictureUrl
                };

                await _repository.AddAsync(entity);
                await _repository.SaveChangesAsync();

                return entity.Id;
            }

            public async Task<bool> UpdateAsync(int id, UserVM model)
            {
                try
                {
                    var updatedUser = new User
                    {
                        Id = id,
                        FirstName = model.FirstName,
                        MiddleName = model.MiddleName,
                        LastName = model.LastName,
                        DateOfBirth = model.DateOfBirth,
                        ProfilePictureUrl = model.ProfilePictureUrl
                    };

                    await _repository.UpdateAsync(id.ToString(), updatedUser);
                    await _repository.SaveChangesAsync();
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }

            public async Task<bool> DeleteAsync(int id)
            {
                try
                {
                    var user = await _repository.GetByIdAsync<User>(id.ToString());
                    user.IsDeleated = true;
                    await _repository.SaveChangesAsync();
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            public async Task<bool> AddOwnedPropertyAsync(int userId, RealEstateOwnershipVM ownershipVm)
            {
                try
                {
                    var ownership = new RealEstateOwnership
                    {
                        UserId = userId,
                        RealEstateId = ownershipVm.RealEstateId,
                        OwnershipPercentage = ownershipVm.OwnershipPercentage,
                        DateAcquired = ownershipVm.DateAcquired,
                    };

                    await _repository.AddAsync(ownership);
                    await _repository.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public async Task<bool> RemoveOwnedPropertyAsync(int userId, int realEstateId)
            {
                try
                {
                    var ownerships = _repository.AllAsync<RealEstateOwnership>();
                    var ownership = await ownerships
                        .FirstOrDefaultAsync(o => o.UserId == userId && o.RealEstateId == realEstateId);

                    if (ownership == null)
                        return false;

                    _repository.DeleteAsync<RealEstateOwnership>(ownership.Id.ToString()); // assuming RealEstateOwnership has an Id key
                    await _repository.SaveChangesAsync();

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            // Update an existing ownership record by userId and realEstateId
            public async Task<bool> UpdateOwnedPropertyAsync(int userId, RealEstateOwnershipVM ownershipVm)
            {
                try
                {
                    var ownerships = _repository.AllAsync<RealEstateOwnership>();
                    var ownership = await ownerships
                        .FirstOrDefaultAsync(o => o.UserId == userId && o.RealEstateId == ownershipVm.RealEstateId);

                    if (ownership == null)
                        return false;

                    ownership.OwnershipPercentage = ownershipVm.OwnershipPercentage;
                    ownership.DateAcquired = ownershipVm.DateAcquired;

                    await _repository.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }


}
