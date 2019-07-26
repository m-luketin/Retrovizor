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
    public class StudentController : ControllerBase
    {
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        private readonly IStudentRepository _studentRepository;

        [HttpGet("all")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentRepository.GetAllStudents());
        }

        [HttpPost("add")]
        public IActionResult AddStudent(Student studentToAdd)
        {
            var wasAddSuccessful = _studentRepository.AddStudent(studentToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [HttpPost("edit")]
        public IActionResult EditStudent(Student editedStudent)
        {
            var wasEditSucessful = _studentRepository.EditStudent(editedStudent);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var wasDeleteSucessful = _studentRepository.DeleteStudent(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var studentToGet = _studentRepository.GetStudentById(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }
    }
}