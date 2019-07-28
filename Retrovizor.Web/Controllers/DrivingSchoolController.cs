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
    public class DrivingSchoolController : ControllerBase
    {
        public DrivingSchoolController(IDrivingSchoolRepository drivingSchoolRepository)
        {
            _drivingSchoolRepository = drivingSchoolRepository;
        }
        private readonly IDrivingSchoolRepository _drivingSchoolRepository;

        [HttpGet("all")]
        public IActionResult GetAllDrivingSchools()
        {
            return Ok(_drivingSchoolRepository.GetAllDrivingSchools());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetDrivingSchoolById(int id)
        {
            var drivingSchoolToGet = _drivingSchoolRepository.GetDrivingSchoolById(id);

            if(drivingSchoolToGet == null)
                return NotFound();

            return Ok(drivingSchoolToGet);
        }

        [HttpGet("get-by-student/{id}")]
        public IActionResult GetDrivingSchoolByInstructorId(int id)
        {
            var classes = _drivingSchoolRepository.GetDrivingSchoolByInstructorId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }

        [HttpGet("get-by-student/{id}")]
        public IActionResult GetDrivingSchoolByStudentId(int id)
        {
            var classes = _drivingSchoolRepository.GetDrivingSchoolByStudentId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }

        [HttpGet("get-by-student/{id}")]
        public IActionResult GetDrivingSchoolByAdminId(int id)
        {
            var classes = _drivingSchoolRepository.GetDrivingSchoolByAdminId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }
    }
}