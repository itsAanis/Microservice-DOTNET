using Domain.MappingIThink;
using Domain.Models;
using FCommon.Queries.Abstractions;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Repositories;
using Recreate.Infrastructure.Data.Repositories.Abstraction;

namespace FCommon.Queries
{ // take in and returns from repo entity convert using mapper to dto
    public class VehicleService : IVehicleQueries
    {
        private readonly IVehicle _vehiclesRepository;
       
        public VehicleService(IVehicle vehiclesRepository)
        {
            _vehiclesRepository = vehiclesRepository;
        }
        
        public async Task<VehicleBaseDto> GetVehicleById(int id)
        {
          Vehicle vehicle = await _vehiclesRepository.GetById(id);
           
         VehicleBaseDto vehicleBaseDto = VehicleMapper.toDto(vehicle);
            return vehicleBaseDto;
            
            
        }

        //GetAll
        public async Task <List<VehicleBaseDto>> GetAllVehicles ()
        {
            List<Vehicle> something =  await _vehiclesRepository.GetAll();
        List<VehicleBaseDto> somethingOne = something.Select(vehicle => new VehicleBaseDto()
        {
            Id = vehicle.Id,
            Model = vehicle.Model,
            LocationId = (int)vehicle.LocationId,
            Price = vehicle.Price,
            Mileage = vehicle.Mileage,
            Make = vehicle.Make
        }).ToList();

            return somethingOne;
        } 


        // post 
        public async Task<VehicleBaseDto> AddVehicleToDb(VehicleBaseDto vehicle)
        {
           Vehicle full = VehicleMapper.ToEntity(vehicle);
            Vehicle returned = await _vehiclesRepository.AddToDb(full);
            return VehicleMapper.toDto(returned);

        }

        // put

       
        public async Task<bool> UpdateVehicleInDb(int id ,VehicleBaseDto vehicle)
        {
           
            VehicleBaseDto vehiclePut = await GetVehicleById(id);
            //return vehicle using ID 
            if (vehiclePut != null)
            {       // turn it into entity 
                Vehicle fun = VehicleMapper.ToEntity(vehicle);
                // send entity to update DB
                bool done = await _vehiclesRepository.UpdateDb(fun, id);
                // returns 
                return done;
            }

            return false;

            // or pass both and handle in repository ? 


        } 




        // delete 
        public async Task<bool> DeleteVehicleById(int id)
        {
            bool something = await _vehiclesRepository.DeleteById(id);
            return something;
        }

       
    }
}
