using Domain.MappingIThink;
using Domain.Models;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Repositories;
using Recreate.Infrastructure.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCommon.Queries
{
    public class LocationService
    {
        private readonly ILocation _LocationRepository;
        public LocationService(ILocation LocationRepository)
        {

            _LocationRepository = LocationRepository;
        }

        public async Task<LocationDto> GetLocationById(int id)
        {
            var location = await _LocationRepository.GetById(id);

            LocationDto locationBaseDto = LocationMapper.toDto(location);
            return locationBaseDto;
        }

        public async Task<LocationDto> AddLocationToDb(LocationDto location)
        {
            Location full = LocationMapper.ToEntity(location);
            Location returned = await _LocationRepository.AddToDb(full);
            return LocationMapper.toDto(returned);

        }

        //get all locations
        public async Task<List<LocationDto>> GetAllLocations()
        {
            List<Location> something = await _LocationRepository.GetAll();
            List<LocationDto> somethingOne = something.Select(location => new LocationDto()
            {
                Name = location.Name
               
            }).ToList();

            return somethingOne;
        }


        public async Task<bool> DeleteLocationById(int id)
        {
            bool something = await _LocationRepository.DeleteById(id);
            return something;
        }

        public async Task<bool> UpdateLocationInDb(int id, LocationDto location)
        {

            LocationDto locationPut = await GetLocationById(id);
            //return vehicle using ID 
            if (locationPut != null)
            {       // turn it into entity 
                Location fun = LocationMapper.ToEntity(location);
                // send entity to update DB
                bool done = await _LocationRepository.UpdateDb(fun, id);
                // returns 
                return done;
            }
            return false;
        }


        }
}
