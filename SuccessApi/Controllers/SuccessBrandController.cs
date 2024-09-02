using FCommon.Queries.Abstractions;
using FCommon.Queries;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using SuccessApi.ViewModel;
using Recreate.Infrastructure.Data.Entities;

namespace SuccessApi.Controllers
{
    [Produces("application/json")]
    [Route("SuccessBrand")]
    [ApiController]

    public class SuccessBrandController : Controller
    {
        private readonly BrandService _BrandService;
        private readonly BrandLocationService _BrandLocationService;
      
        public SuccessBrandController(BrandService brand, BrandLocationService brandLocationService)
        {
            _BrandService = brand;
            _BrandLocationService = brandLocationService;
        }


        [HttpGet("BrandLocation")]

        public async Task<IActionResult> GetAllBrandLocations(int id)
        {
            List<BrandLocationDto> result = await _BrandLocationService.GetallBrandLocation();

            if (result == null)
            {
                return NotFound("sorry");
            }

            return Ok(result);
        }


    



            [HttpGet("{id}")]

        public async Task<IActionResult> GetBrand(int id)
        {
            //
            BrandDto result = await _BrandService.GetBrandById(id);


            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }
        // get all brands
        [HttpGet("brands")]
        public async Task<IActionResult> AllBrands()
        {
            List<BrandDto> result = await _BrandService.GetAllBrands();

            if (result == null)
            {
                return NotFound("sorry");
            }

            return Ok(result);
        }


        [HttpPost("Brand")]
        public async Task<IActionResult> AddBrandToDb(BrandModel brand)
        {
            BrandDto brandDto = new BrandDto
            {
               
                Name = brand.Name,
            };



            BrandDto result = await _BrandService.AddBrandToDb(brandDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


        [HttpDelete("Brand/{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {

            bool result = await _BrandService.DeleteBrandById(id);

            if (result == false)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPut("Brand/{id}")]
        public async Task<IActionResult> UpdateBrand(int id, BrandModel brand)
        {

            BrandDto brandDto = new BrandDto
            {
                Id = id,
               Name = brand.Name,
            };


            bool result = await _BrandService.UpdateBrandInDb(id, brandDto);

           

            return Ok(result);

        } 

    }
}
