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
    public class StudentExamController : ControllerBase
    {
        public StudentExamController(IStudentExamRepository studentExamRepository)
        {
            _studentExamRepository = studentExamRepository;
        }
        private readonly IStudentExamRepository _studentExamRepository;

        [HttpPost("edit-student-exam")]
        public IActionResult EditStudentExam(StudentExam studentExamToEdit)
        {
            var wasEditSucessful = _studentExamRepository.EditStudentExam(studentExamToEdit);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [HttpPost("assign-exam")]
        public IActionResult AssignExamToStudent(StudentExam studentExam)
        {
            var wasSucessful = _studentExamRepository.AddStudentExam(studentExam);

            if(wasSucessful)
                return Ok();

            return Forbid();
        }

        [HttpDelete("delete-student-class")]
        public IActionResult DeleteStudentExam(int studentId, int examId)
        {
            var wasSucessful = _studentExamRepository.DeleteStudentExam(studentId, examId);

            if(wasSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get")]
        public IActionResult GetStudentExam(int studentId, int examId)
        {
            var studentExamToGet = _studentExamRepository.GetStudentExam(studentId, examId);

            if(studentExamToGet == null)
                return NotFound();

            return Ok(studentExamToGet);
        }
    }
}