using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        public InstructorController(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        private readonly IInstructorRepository _instructorRepository;

        [Authorize]
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetAllInstructors(int id)
        {
            return Ok(_instructorRepository.GetAllInstructorsByDrivingSchoolId(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public IActionResult AddInstructor(Instructor instructorToAdd)
        {
            var wasAddSuccessful = _instructorRepository.AddInstructor(instructorToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("edit")]
        public IActionResult EditInstructor(Instructor editedInstructor)
        {
            var wasEditSucessful = _instructorRepository.EditInstructor(editedInstructor);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteInstructor(int id)
        {
            var wasDeleteSucessful = _instructorRepository.DeleteInstructor(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetCurrentInstructorByStudentId(int id)
        {
            var instructorToGet = _instructorRepository.GetCurrentInstructorByStudentId(id);

            if(instructorToGet == null)
                return NotFound();

            return Ok(instructorToGet);
        }

        [Authorize]
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetInstructorsByDrivingSchoolId(int id)
        {
            var instructorsToGet = _instructorRepository.GetInstructorsByDrivingSchoolId(id);

            if(instructorsToGet == null)
                return NotFound();

            return Ok(instructorsToGet);
        }
    }
}