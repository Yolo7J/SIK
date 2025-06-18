using Microsoft.EntityFrameworkCore;
using SIK.Infrastructure.Data.Common;
using SIK.Infrastructure.Data.Models;

namespace SIK.Core.Models.Services
{
    public class TransportAssetService
    {
        private readonly Repository _repository;

        public TransportAssetService(Repository repository)
        {
            _repository = repository;
        }

        public async Task<List<TransportAssetVM>> GetAllAsync()
        {
            return await _repository.AllAsNoTrackingAsync<TransportAsset>()
                .Select(t => new TransportAssetVM
                {
                    Id = t.Id,
                    Type = t.Type,
                    YearOfManufacture = t.YearOfManufacture,
                    Name = t.Name,
                    Description = t.Description,
                    OwnerId = t.OwnerId,
                    OwnerFullName = t.Owner.FirstName + " " + t.Owner.LastName,
                    Price = t.Price,
                    ImageUrl = t.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<TransportAssetVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync<TransportAsset>(id.ToString());

                return new TransportAssetVM
                {
                    Id = entity.Id,
                    Type = entity.Type,
                    YearOfManufacture = entity.YearOfManufacture,
                    Name = entity.Name,
                    Description = entity.Description,
                    OwnerId = entity.OwnerId,
                    OwnerFullName = entity.Owner.FirstName + " " + entity.Owner.LastName,
                    Price = entity.Price,
                    ImageUrl = entity.ImageUrl
                };
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public async Task<int> CreateAsync(TransportAssetVM model)
        {
            var entity = new TransportAsset
            {
                Type = model.Type,
                YearOfManufacture = model.YearOfManufacture,
                Name = model.Name,
                Description = model.Description,
                OwnerId = model.OwnerId,
                Price = model.Price,
                ImageUrl = model.ImageUrl
            };

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> UpdateAsync(int id, TransportAssetVM model)
        {
            try
            {
                var updatedEntity = new TransportAsset
                {
                    Id = id,
                    Type = model.Type,
                    YearOfManufacture = model.YearOfManufacture,
                    Name = model.Name,
                    Description = model.Description,
                    OwnerId = model.OwnerId,
                    Price = model.Price,
                    ImageUrl = model.ImageUrl
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
                await _repository.DeleteAsync<TransportAsset>(id.ToString());
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
    }
}
