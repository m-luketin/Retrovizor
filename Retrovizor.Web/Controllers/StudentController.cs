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
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetStudentsByDrivingSchoolId(int id)
        {
            var studentToGet = _studentRepository.GetStudentsByDrivingSchoolId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }
        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetStudentsByInstructorId(int id)
        {
            var studentToGet = _studentRepository.GetStudentsByInstructorId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }
        [HttpGet("get-current-by-instructor/{id}")]
        public IActionResult GetCurrentStudentsByInstructorId(int id)
        {
            var studentToGet = _studentRepository.GetCurrentStudentsByInstructorId(id);

            if(studentToGet == null)
                return NotFound();

            return Ok(studentToGet);
        }

        [HttpPost("edit-current-lesson")]
        public IActionResult EditCurrentLesson(int studentId, int classId, int newCurrentLesson)
        {
            var wasEditSucessful = _studentRepository.EditCurrentLesson(studentId, classId, newCurrentLesson);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }
        [HttpPost("edit-exam-points")]
        public IActionResult EditExamPoints(int studentId, int classId, int newPoints)
        {
            var wasEditSucessful = _studentRepository.EditExamPoints(studentId, classId, newPoints);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }
        [HttpPost("did-pass-exam")]
        public IActionResult HasStudentPassedExam(int studentId, int examId)
        {
            var didPass = _studentRepository.HasStudentPassedExam(studentId, examId);

            return Ok(didPass);
        }
    }
}