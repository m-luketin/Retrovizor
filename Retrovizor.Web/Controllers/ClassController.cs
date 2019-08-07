using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        private readonly IClassRepository _classRepository;

        [Authorize(Roles = "Developer")]
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetAllClasses(int id)
        {
            return Ok(_classRepository.GetAllClassesByDrivingSchoolId(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public IActionResult AddClass(Class classToAdd)
        {
            var wasAddSuccessful = _classRepository.AddClass(classToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("edit")]
        public IActionResult EditClass(Class editedClass)
        {
            var wasEditSucessful = _classRepository.EditClass(editedClass);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteClass(int id)
        {
            var wasDeleteSucessful = _classRepository.DeleteClass(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize]
        [HttpGet("get/{id}")]
        public IActionResult GetClassById(int id)
        {
            var classToGet = _classRepository.GetClassById(id);

            if(classToGet == null)
                return NotFound();

            return Ok(classToGet); 
        }

        [Authorize]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetClassesByStudentId(int id)
        {
            var classes = _classRepository.GetClassesByStudentId(id);

            if(classes == null)
                return NotFound();

            return Ok(classes);
        }
    }
}