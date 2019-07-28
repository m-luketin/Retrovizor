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
    public class StudentEventController : ControllerBase
    {
        public StudentEventController(IStudentEventRepository studentEventRepository)
        {
            _studentEventRepository = studentEventRepository;
        }
        private readonly IStudentEventRepository _studentEventRepository;

        [HttpPost("add")]
        public IActionResult AddStudentEvent(StudentEvent studentEvent)
        {
            var wasSucessful = _studentEventRepository.AddStudentEvent(studentEvent);

            if(wasSucessful)
                return Ok();

            return Forbid();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteStudentEvent(int studentId, int eventId)
        {
            var wasDeleteSucessful = _studentEventRepository.DeleteStudentEvent(studentId, eventId);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }
    }
}