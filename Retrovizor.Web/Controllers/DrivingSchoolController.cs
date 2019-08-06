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

        [Authorize(Roles = "Developer")]
        [HttpGet("get/{id}")]
        public IActionResult GetDrivingSchoolById(int id)
        {
            var drivingSchoolToGet = _drivingSchoolRepository.GetDrivingSchoolById(id);

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
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var classes = _drivingSchoolRepository.GetDrivingSchoolByAdminId(userCredentials.Id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }
    }
}