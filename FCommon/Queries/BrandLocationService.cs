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
    public class BrandLocationService
    {
        private readonly IBrandLocation _BrandLocationRepository;

        public BrandLocationService(IBrandLocation brandLocation)
        {

            _BrandLocationRepository = brandLocation;
        }


        public async Task <List<BrandLocationDto>> GetallBrandLocation()
        {
            var something = await _BrandLocationRepository.GetAllBrandLocation();

            var somethingOne = something.Select(x => new BrandLocationDto()
            {
                BrandId = x.Item1,
                BrandName = x.Item2,
                LocationId = x.Item3,
                LocationName = x.Item4
            }).ToList();

            return somethingOne;
        }

    }
}
