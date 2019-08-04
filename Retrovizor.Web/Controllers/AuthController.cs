using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        public AuthController(JwtHelper jwtHelper, IStudentRepository studentRepository,
            IInstructorRepository instructorRepository, IAdminRepository adminRepository)
        {
            _studentRepository = studentRepository;
            _instructorRepository = instructorRepository;
            _adminRepository = adminRepository;
            _jwtHelper = jwtHelper;
        }

        private readonly IStudentRepository _studentRepository;
        private readonly IInstructorRepository _instructorRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly JwtHelper _jwtHelper;

        [HttpPost("login")]
        public IActionResult Login(UserCredentials credentials)
        {            
            UserCredentials verifiedCredentials = null;

            verifiedCredentials = _adminRepository.VerifyCredentials(credentials);

            if (verifiedCredentials == null)
            {
                verifiedCredentials = _instructorRepository.VerifyCredentials(credentials);

                if(verifiedCredentials == null)
                {
                    verifiedCredentials = _studentRepository.VerifyCredentials(credentials);

                    if (verifiedCredentials == null)
                        return BadRequest("Username or password is incorrect");
                }
            }

            return Ok(_jwtHelper.GetJwtToken(verifiedCredentials));
        }

        /*[HttpPost("refresh")]
        public IActionResult Refresh(string token, string refreshToken)
        {
            var principal = _jwtHelper.GetNewToken(token);
            var username = principal.Identity.Name;
            var savedRefreshToken = ;
        }*/
        
        [Authorize(Roles = "Admin")]
        [HttpGet("test-authorize")]
        public IActionResult TestAuthorize()
        {
            return Ok("Authorized");
        }
    }
}
