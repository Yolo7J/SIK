using Microsoft.EntityFrameworkCore;
using SIK.Infrastructure.Data.Common;
using SIK.Infrastructure.Data.Models;

namespace SIK.Core.Models.Services
{
    public class ServiceService
    {
        private readonly Repository _repository;

        public ServiceService(Repository repository)
        {
            _repository = repository;
        }

        public async Task<List<ServiceVM>> GetAllAsync()
        {
            return await _repository.AllAsNoTrackingAsync<Service>()
                .Select(s => new ServiceVM
                {
                    Id = s.Id,
                    PricePerMonth = s.PricePerMonth,
                    Description = s.Description,
                    Signed = s.Signed,
                    LastChanged = s.LastChanged,
                    SignatoryId = s.SignatoryId,
                    SignatoryFullName = s.Signatory.FirstName + " " + s.Signatory.LastName,
                    RealEstateId = s.RealEstateId,
                    RealEstateAddress = s.RealEstate != null ? s.RealEstate.Adress : null,
                    TransportAssetId = s.TransportAssetId,
                    TransportAssetName = s.TransportAsset != null ? s.TransportAsset.Name : null,
                    ServiceType = s.ServiceType
                })
                .ToListAsync();
        }

        public async Task<ServiceVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync<Service>(id.ToString());
                return new ServiceVM
                {
                    Id = entity.Id,
                    PricePerMonth = entity.PricePerMonth,
                    Description = entity.Description,
                    Signed = entity.Signed,
                    LastChanged = entity.LastChanged,
                    SignatoryId = entity.SignatoryId,
                    SignatoryFullName = entity.Signatory.FirstName + " " + entity.Signatory.LastName,
                    RealEstateId = entity.RealEstateId,
                    RealEstateAddress = entity.RealEstate?.Adress,
                    TransportAssetId = entity.TransportAssetId,
                    TransportAssetName = entity.TransportAsset?.Name,
                    ServiceType = entity.ServiceType
                };
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public async Task<int> CreateAsync(ServiceVM model)
        {
            var entity = new Service
            {
                PricePerMonth = model.PricePerMonth,
                Description = model.Description,
                Signed = model.Signed,
                LastChanged = model.LastChanged,
                SignatoryId = model.SignatoryId,
                RealEstateId = model.RealEstateId,
                TransportAssetId = model.TransportAssetId,
                ServiceType = model.ServiceType
            };

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(int id, ServiceVM model)
        {
            try
            {
                var updatedEntity = new Service
                {
                    Id = id,
                    PricePerMonth = model.PricePerMonth,
                    Description = model.Description,
                    Signed = model.Signed,
                    LastChanged = model.LastChanged,
                    SignatoryId = model.SignatoryId,
                    RealEstateId = model.RealEstateId,
                    TransportAssetId = model.TransportAssetId,
                    ServiceType = model.ServiceType
                };

                await _repository.UpdateAsync(id.ToString(), updatedEntity);
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
                await _repository.DeleteAsync<Service>(id.ToString());
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
        public async Task<bool> RemoveOwnerAsync(int realEstateId, int userId)
        {
            try
            {
                var ownerships = _repository.AllAsync<RealEstateOwnership>();
                var ownership = await ownerships
                    .FirstOrDefaultAsync(o => o.RealEstateId == realEstateId && o.UserId == userId);

                if (ownership == null)
                    return false;

                _repository.DeleteAsync<RealEstateOwnership>(ownership.Id.ToString()); // assuming ownership has an Id key
                await _repository.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Update an owner record by realEstateId and userId
        public async Task<bool> UpdateOwnerAsync(int realEstateId, RealEstateOwnershipVM ownershipVm)
        {
            try
            {
                var ownerships = _repository.AllAsync<RealEstateOwnership>();
                var ownership = await ownerships
                    .FirstOrDefaultAsync(o => o.RealEstateId == realEstateId && o.UserId == ownershipVm.UserId);

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
