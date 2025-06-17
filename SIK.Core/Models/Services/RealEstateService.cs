using SIK.Core.Models;
using SIK.Infrastructure.Data.Common;
using SIK.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace SIK.Core.Models.Services
{
    public class RealEstateService
    {
        private readonly Repository _repository;

        public RealEstateService(Repository repository)
        {
            _repository = repository;
        }

        public async Task<List<RealEstateVM>> GetAllAsync()
        {
            return await _repository.AllAsNoTrackingAsync<RealEstate>()
                .Select(re => new RealEstateVM
                {
                    Id = re.Id,
                    Adress = re.Adress,
                    AreaInSqrMeters = re.AreaInSqrMeters,
                    YearOfConstruction = re.YearOfConstruction,
                    MarketPrice = re.MarketPrice,
                    ImageUrl = re.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<RealEstateVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync<RealEstate>(id.ToString());
                return new RealEstateVM
                {
                    Id = entity.Id,
                    Adress = entity.Adress,
                    AreaInSqrMeters = entity.AreaInSqrMeters,
                    YearOfConstruction = entity.YearOfConstruction,
                    MarketPrice = entity.MarketPrice,
                    ImageUrl = entity.ImageUrl
                };
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public async Task<int> CreateAsync(RealEstateVM model)
        {
            var entity = new RealEstate
            {
                Adress = model.Adress,
                AreaInSqrMeters = model.AreaInSqrMeters,
                YearOfConstruction = model.YearOfConstruction,
                MarketPrice = model.MarketPrice,
                ImageUrl = model.ImageUrl
            };

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> UpdateAsync(int id, RealEstateVM model)
        {
            try
            {
                var updatedEntity = new RealEstate
                {
                    Id = id,
                    Adress = model.Adress,
                    AreaInSqrMeters = model.AreaInSqrMeters,
                    YearOfConstruction = model.YearOfConstruction,
                    MarketPrice = model.MarketPrice,
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
                await _repository.DeleteAsync<RealEstate>(id.ToString());
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
