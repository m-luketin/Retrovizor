using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        private readonly ILocationRepository _locationRepository;

        [Authorize]
        [HttpPost("add")]
        public IActionResult AddLocation(Location locationToAdd)
        {
            var wasAddSuccessful = _locationRepository.AddLocation(locationToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize]
        [HttpPost("edit")]
        public IActionResult EditLocation(Location editedLocation)
        {
            var wasEditSucessful = _locationRepository.EditLocation(editedLocation);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteLocation(int id)
        {
            var wasDeleteSucessful = _locationRepository.DeleteLocation(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize]
        [HttpGet("get/{id}")]
        public IActionResult GetLocationById(int id)
        {
            var locationToGet = _locationRepository.GetLocationById(id);

            if(locationToGet == null)
                return NotFound();

            return Ok(locationToGet);
        }

        [Authorize]
        [HttpGet("get-by-event/{id}")]
        public IActionResult GetLocationByEventId(int id)
        {
            var locationToGet = _locationRepository.GetLocationByEventId(id);

            if(locationToGet == null)
                return NotFound();

            return Ok(locationToGet);
        }
    }
}