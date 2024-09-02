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
    public class BrandService
    {

        private readonly IBrand _BrandRepository;
        public BrandService(IBrand BrandRepository) {

            _BrandRepository = BrandRepository;
        }

        public async Task<BrandDto> GetBrandById(int id)
        {
            var brand = await _BrandRepository.GetById(id);

            BrandDto brandBaseDto = BrandMapper.toDto(brand);
            return brandBaseDto;

        }

        // get all brands
        public async Task<List<BrandDto>> GetAllBrands()
        {
            List<Brand> something = await _BrandRepository.GetAll();
            List<BrandDto> somethingOne = something.Select(brand => new BrandDto()
            {
                Name = brand.Name

            }).ToList();

            return somethingOne;

        }

            public async Task<BrandDto> AddBrandToDb(BrandDto brand)
        {
            Brand full = BrandMapper.ToEntity(brand);
            Brand returned = await _BrandRepository.AddToDb(full);
            return BrandMapper.toDto(returned);

        }
        public async Task<bool> DeleteBrandById(int id)
        {
            bool something = await _BrandRepository.DeleteById(id);
            return something;
        }

        public async Task<bool> UpdateBrandInDb(int id, BrandDto brand)
        {

            BrandDto brandPut = await GetBrandById(id);
            //return vehicle using ID 
            if (brandPut != null)
            {       // turn it into entity 
                Brand fun = BrandMapper.ToEntity(brand);
                // send entity to update DB
                bool done = await _BrandRepository.UpdateDb(fun, id);
                // returns 
                return done;
            }

            return false;

        }

        }
}
