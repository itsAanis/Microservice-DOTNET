
using Domain.Models;

namespace FCommon.Queries.Abstractions
{
    public interface IVehicleQueries
    {
        public  Task<VehicleBaseDto> GetVehicleById(int id);
        public Task<bool> UpdateVehicleInDb(int id , VehicleBaseDto vehicle);

        public Task <bool> DeleteVehicleById(int id);

        public Task<VehicleBaseDto> AddVehicleToDb(VehicleBaseDto vehicle);

        public Task <List<VehicleBaseDto>> GetAllVehicles();


    }
}
