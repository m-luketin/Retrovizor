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
    public class StudentController : ControllerBase
    {
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        private readonly IStudentRepository _studentRepository;

        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentRepository.GetAllStudents());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public IActionResult AddStudent(Student studentToAdd)
        {
            var wasAddSuccessful = _studentRepository.AddStudent(studentToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("edit")]
        public IActionResult EditStudent(Student editedStudent)
        {
            var wasEditSucessful = _studentRepository.EditStudent(editedStudent);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var wasDeleteSucessful = _studentRepository.DeleteStudent(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetStudentsByDrivingSchoolId(int id)
        {
            var studentToGet = _studentRepository.GetStudentsByDrivingSchoolId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetStudentsByInstructorId(int id)
        {
            var studentToGet = _studentRepository.GetStudentsByInstructorId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }

        [Authorize(Roles = "Admin, Instructor")]
        [HttpGet("get-current-by-instructor/{id}")]
        public IActionResult GetCurrentStudentsByInstructorId(int id)
        {
            var studentToGet = _studentRepository.GetCurrentStudentsByInstructorId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }
    }
}