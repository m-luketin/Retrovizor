using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        public StudentClassController(IStudentClassRepository studentClassRepository)
        {
            _studentClassRepository = studentClassRepository;
        }
        private readonly IStudentClassRepository _studentClassRepository;

        [Authorize(Roles = "Admin")]
        [HttpPost("edit")]
        public IActionResult EditStudentClass(StudentClass studentClassToEdit)
        {
            var wasEditSucessful = _studentClassRepository.EditStudentClass(studentClassToEdit);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public IActionResult AddStudentClass(StudentClass studentClassToAdd)
        {
            var wasSucessful = _studentClassRepository.AddStudentClass(studentClassToAdd);

            if(wasSucessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete")]
        public IActionResult DeleteStudentClass(int studentId, int classId)
        {
            var wasSucessful = _studentClassRepository.DeleteStudentClass(studentId, classId);

            if(wasSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize]
        [HttpGet("get")]
        public IActionResult GetStudentClass(int studentId, int classId)
        {
            var studentClassToGet = _studentClassRepository.GetStudentClass(studentId, classId);

            if(studentClassToGet == null)
                return NotFound();

            return Ok(studentClassToGet);
        }
    }
}