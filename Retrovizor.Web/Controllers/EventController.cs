using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Helpers;
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

        [Authorize(Roles = "Admin, Instructor")]
        [HttpPost("add")]
        public IActionResult AddEvent(Event eventToAdd)
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var wasAddSuccessful = _eventRepository.AddEvent(eventToAdd, userCredentials.Id);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin, Instructor")]
        [HttpPost("edit")]
        public IActionResult EditEvent(Event editedEvent)
        {
            var wasEditSucessful = _eventRepository.EditEvent(editedEvent);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin, Instructor")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteEvent(int id)
        {                                                              
            var wasDeleteSucessful = _eventRepository.DeleteEvent(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetEventById(int id)
        {
            var eventToGet = _eventRepository.GetEventById(id);

            if(eventToGet == null)
                return NotFound();

            return Ok(eventToGet);
        }

        [Authorize]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetEventsByStudentId(int id)
        {
            var events = _eventRepository.GetEventsByStudentId(id);

            if(events == null)
                return NotFound();

            return Ok(events);
        }

        [Authorize(Roles = "Admin, Instructor")]
        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetInstructorSchedule(int id)
        {
            var instructorSchedule = _eventRepository.GetInstructorDrivingLessonsByInstructorId(id);

            if(instructorSchedule == null)
                return NotFound();

            return Ok(instructorSchedule);
        }
    }
}
