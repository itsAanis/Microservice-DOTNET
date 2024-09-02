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
    public class VehicleImageService
    {
        private readonly IVehicleImage _vehicleImageRepository;

        public VehicleImageService(IVehicleImage vehicleImageRepository)
        {
            _vehicleImageRepository = vehicleImageRepository;
        }


        public async Task<VehicleImageDto> GetVehicleById(int id)
        {

            VehicleImage vehicle = await _vehicleImageRepository.GetImagesByVehicleId(id);
               VehicleImageDto mapped = VehicleImageMapper.toDto(vehicle);

            // map first ? 
            return mapped;

        }


    }
}
