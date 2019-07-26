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
    public class EventController : ControllerBase
    {
        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        private readonly IEventRepository _eventRepository;

        [HttpGet("all")]
        public IActionResult GetAllEvents()
        {
            return Ok(_eventRepository.GetAllEvents());
        }

        [HttpPost("add")]
        public IActionResult AddEvent(Event eventToAdd)
        {
            var wasAddSuccessful = _eventRepository.AddEvent(eventToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [HttpPost("edit")]
        public IActionResult EditEvent(Event editedEvent)
        {
            var wasEditSucessful = _eventRepository.EditEvent(editedEvent);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteEvent(int id)
        {
            var wasDeleteSucessful = _eventRepository.DeleteEvent(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get/{id}")]
        public IActionResult GetEventById(int id)
        {
            var eventToGet = _eventRepository.GetEventById(id);

            if(eventToGet == null)
                return NotFound();

            return Ok(eventToGet);
        }
    }
}