using Microsoft.AspNetCore.Mvc;
using FCommon.Queries.Abstractions;
using Domain.Models;
using FCommon.Queries;
using SuccessApi.ViewModel;
using Recreate.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Net;

namespace SuccessApi.Controllers
{
    [Produces("application/json")]
    [Route("Success")]
    [ApiController]
    public class SuccessController : Controller
    {

        private readonly IVehicleQueries _vehicleService;
        private readonly VehicleImageService _vehicleImageService;
        private readonly ILogger<SuccessController> _logger;

        public SuccessController(IVehicleQueries vehicleService, VehicleImageService vehicleImageService,
              ILogger<SuccessController> logger)
        {
            _vehicleService = vehicleService;
            _vehicleImageService = vehicleImageService;
            _logger = logger;
        }



        [HttpGet("vehicles/{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {

          try
            {
                VehicleBaseDto result = await _vehicleService.GetVehicleById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError( ex,
                  "An error occurred while getting vehicle{id}", id);
            }

            return StatusCode((int)HttpStatusCode.InternalServerError);


        }

        // getAll Vehicles 
        [HttpGet("vehicles")]
        public async Task <IActionResult> AllVehicles()
        {
            List<VehicleBaseDto> result =  await _vehicleService.GetAllVehicles();

            if (result == null)
            {
                return NotFound("sorry");
            }

            return Ok(result);
        }


        // post 
        [HttpPost("vehicles")]
        public async Task<IActionResult> AddVehicleToDb(VehicleModelAPI vehicle)
        {

            try
            {

                VehicleBaseDto vehicleDto = new VehicleBaseDto
                {
                    Model = vehicle.Model,
                    Make = vehicle.Make,
                    LocationId = vehicle.LocationId,
                    Price = vehicle.Price,
                    Mileage = vehicle.Mileage,
                };

                VehicleBaseDto result = await _vehicleService.AddVehicleToDb(vehicleDto);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,
                  "An error occurred while getting");
            }

            return StatusCode((int)HttpStatusCode.InternalServerError);

        }



        // put
        [HttpPut("vehicles/{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, VehicleModelAPI vehicle)
        { // change to viewmodel 

            VehicleBaseDto vehicleDto = new VehicleBaseDto
            {
                Id = id,
                Model = vehicle.Model,
                Make = vehicle.Make,
                LocationId = vehicle.LocationId,
                Price = vehicle.Price,
                Mileage = vehicle.Mileage
            };


            bool result = await _vehicleService.UpdateVehicleInDb(id, vehicleDto);

           

            return Ok(result);

        }



        // delete 
        [HttpDelete("vehicles/{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {

            bool result = await _vehicleService.DeleteVehicleById(id);

            if (result == false)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpGet("images{id}")]

        public async Task<IActionResult> GetVehicleImages(int id)
        {
            // take vehicle in but return vehicle and images

            var result = await _vehicleImageService.GetVehicleById(id);


            VehicleBaseDto results = await _vehicleService.GetVehicleById(id);



            if (result == null)
            {
                return NotFound();
            }


            Object resultss = new
            {
                Image = result,
                Vehicle = results


            };

            return Ok(resultss);

        }

/*
        [HttpPost("/images")]

        public async Task<IActionResult> AddVehicleImage(int id, VehicleImageModel image)
        {
            VehicleImageDto vehicleImageDto = new VehicleImageDto
            {
                ImageUrl = image.ImageUrl,
                 VehicleId = id
        };

            VehicleImageDto result = await _vehicleImageService.AddVehicleToDb(vehicleImageDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        method to add vehicle images to vehicle image db using vehicle ID.
        */


    }

    }


    

