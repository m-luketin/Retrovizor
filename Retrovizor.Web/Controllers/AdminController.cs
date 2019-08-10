using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        private readonly IAdminRepository _adminRepository;

        [Authorize(Roles = "Admin")]
        [HttpGet("get")]
        public IActionResult GetAdminById()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            if (accessTokenAsString == "null") return Unauthorized();
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var admin = _adminRepository.GetAdminByUserId(userCredentials.Id);

            if (admin == null) return NotFound();
            return Ok(admin);
        } 

        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetAdminsByDrivingSchoolId(int id)
        {
            var adminsToGet = _adminRepository.GetAdminsByDrivingSchoolId(id);

            if(adminsToGet == null)
                return NotFound();

            return Ok();
        }
    }
}