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
    public class VehicleSessionController : ControllerBase
    {
        public VehicleSessionController(IVehicleSessionRepository vehicleSessionRepository)
        {
            _vehicleSessionRepository = vehicleSessionRepository;
        }
        private readonly IVehicleSessionRepository _vehicleSessionRepository;

        [HttpPost("add")]
        public IActionResult AddVehicleSession(VehicleSession vehicleSessionToAdd)
        {
            var wasSucessful = _vehicleSessionRepository.AddVehicleSession(vehicleSessionToAdd);

            if(wasSucessful)
                return Ok();

            return Forbid();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteVehicleSession(int studentId, int instructorId, int vehicleId)
        {
            var wasSucessful = _vehicleSessionRepository.DeleteVehicleSession(studentId, instructorId, vehicleId);
            if(wasSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get-by-student/{id}")]
        public IActionResult GetVehicleSessionByStudentId(int id)
        {
            var vehicleSessionToGet = _vehicleSessionRepository.GetVehicleSessionsByStudentId(id);

            if(vehicleSessionToGet == null)
                return NotFound();

            return Ok(vehicleSessionToGet);
        }

        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetVehicleSessionsByInstructorId(int id)
        {
            var vehicleSessionToGet = _vehicleSessionRepository.GetVehicleSessionsByInstructorId(id);

            if(vehicleSessionToGet == null)
                return NotFound();

            return Ok(vehicleSessionToGet);
        }

        [HttpGet("get-by-vehicle/{id}")]
        public IActionResult GetVehicleSessionsByVehicleId(int id)
        {
            var vehicleSessionToGet = _vehicleSessionRepository.GetVehicleSessionsByVehicleId(id);

            if(vehicleSessionToGet == null)
                return NotFound();

            return Ok(vehicleSessionToGet);
        }
    }
}