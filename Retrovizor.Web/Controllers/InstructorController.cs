using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Helpers;
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

        [Authorize]
        [HttpGet("get/{id}")]
        public IActionResult GetInstructorById()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var id = userCredentials.Id;

            var instructorToGet = _instructorRepository.GetInstructorById(id);

            if (instructorToGet == null)
                return NotFound();

            return Ok(instructorToGet);
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
            var wasEditSuccessful = _instructorRepository.EditInstructor(editedInstructor);

            if(wasEditSuccessful)
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
        public IActionResult GetCurrentInstructorByStudentId()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var id = userCredentials.Id;

            var instructorToGet = _instructorRepository.GetCurrentInstructorByStudentId(id);

            if(instructorToGet == null)
                return NotFound();

            return Ok(instructorToGet);
        }

        [Authorize]
        [HttpGet("get-instructor-by-driving-school/{id}")]
        public IActionResult GetInstructorsByDrivingSchoolId(int id)
        {
            var instructorsToGet = _instructorRepository.GetInstructorsByDrivingSchoolId(id);

            if(instructorsToGet == null)
                return NotFound();

            return Ok(instructorsToGet);
        }

        //[Authorize]
        //[HttpGet("get-available/{id}")]
        //public IActionResult GetAvailableInstructorsByDrivingSchoolId(int id)
        //{
        //    var instructorsToGet = _instructorRepository.GetAvailableInstructorsByDrivingSchoolId(id);

        //    if (instructorsToGet == null)
        //        return NotFound();

        //    return Ok(instructorsToGet);
        //}
    }
}