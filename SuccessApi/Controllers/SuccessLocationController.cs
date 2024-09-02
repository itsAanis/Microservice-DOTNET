using Domain.Models;
using FCommon.Queries;
using FCommon.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using SuccessApi.ViewModel;

namespace SuccessApi.Controllers
{
    
    [Produces("application/json")]
    [Route("LocationSuccess")]
    [ApiController]


    public class SuccessLocationController : Controller
    {
        private readonly LocationService _locationService;

        public SuccessLocationController(LocationService locationService) { 
        
        _locationService = locationService;
        
        }


        [HttpGet("{id}")]

        public async Task<IActionResult> GetLocation(int id)
        {
            LocationDto result = await _locationService.GetLocationById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }
        // get all Locations
        [HttpGet("Locations")]
        public async Task<IActionResult> AllVehicles()
        {
            List<LocationDto> result = await _locationService.GetAllLocations();

            if (result == null)
            {
                return NotFound("sorry");
            }

            return Ok(result);
        }


        [HttpPut("Location/{id}")]
        public async Task<IActionResult> UpdateLocation(int id, LocationModel location)
        {


            LocationDto locationDto = new LocationDto
            {
                Id = id,
                Name = location.Name


            };

            bool result = await _locationService.UpdateLocationInDb(id, locationDto);

         

            return Ok(result);

        }

        [HttpPost("Brand")]
        public async Task<IActionResult> AddLocationToDb(LocationModel location)
        {
            LocationDto locationDto = new LocationDto
            {
                
                Name = location.Name


            };



            LocationDto result = await _locationService.AddLocationToDb(locationDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("Brand/{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {

            bool result = await _locationService.DeleteLocationById(id);

            if (result == false)
            {
                return NotFound();
            }

            return Ok(result);

        }


    }
}
