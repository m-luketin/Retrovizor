using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivingSchoolController : ControllerBase
    {
        public DrivingSchoolController(IDrivingSchoolRepository drivingSchoolRepository)
        {
            _drivingSchoolRepository = drivingSchoolRepository;
        }
        private readonly IDrivingSchoolRepository _drivingSchoolRepository;

        [Authorize]
        [HttpGet("get")]
        public IActionResult GetDrivingSchoolById()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var drivingSchoolToGet = _drivingSchoolRepository.GetDrivingSchoolById(userCredentials.DrivingSchoolId);

            if(drivingSchoolToGet == null)
                return NotFound();

            return Ok(drivingSchoolToGet);
        }

        [Authorize(Roles = "Developer")]
        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetDrivingSchoolByInstructorId(int id)
        {
            var classes = _drivingSchoolRepository.GetDrivingSchoolByInstructorId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }

        [Authorize(Roles = "Developer")]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetDrivingSchoolByStudentId(int id)
        {
            var classes = _drivingSchoolRepository.GetDrivingSchoolByStudentId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-by-admin")]
        public IActionResult GetDrivingSchoolByAdminId()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var classes = _drivingSchoolRepository.GetDrivingSchoolByAdminId(userCredentials.Id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-student-count")]
        public IActionResult GetStudentCount()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            return Ok(_drivingSchoolRepository.GetStudentCount(userCredentials.DrivingSchoolId));
        }
        
        [Authorize(Roles = "Admin")]
        [HttpGet("get-instructor-count")] 
        public IActionResult GetInstructorCount()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            return Ok(_drivingSchoolRepository.GetInstructorCount(userCredentials.DrivingSchoolId));
        }
    }
}