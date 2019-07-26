using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        private readonly IVehicleRepository _vehicleRepository;

        [HttpGet("all")]
        public IActionResult GetAllVehicles()
        {
            return Ok(_vehicleRepository.GetAllVehicles());
        }

        [HttpPost("add")]
        public IActionResult AddVehicle(Vehicle vehicleToAdd)
        {
            var wasAddSuccessful = _vehicleRepository.AddVehicle(vehicleToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [HttpPost("edit")]
        public IActionResult EditVehicle(Vehicle editedVehicle)
        {
            var wasEditSucessful = _vehicleRepository.EditVehicle(editedVehicle);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            var wasDeleteSucessful = _vehicleRepository.DeleteVehicle(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get/{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicleToGet = _vehicleRepository.GetVehicleById(id);

            if(vehicleToGet == null)
                return NotFound();

            return Ok(vehicleToGet);
        }
    }
}