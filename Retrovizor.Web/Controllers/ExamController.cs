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
    public class ExamController : ControllerBase
    {
        public ExamController(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        private readonly IExamRepository _examRepository;

        [Authorize(Roles = "Admin")]
        [HttpGet("get-by-driving-school/{id}")]
        public IActionResult GetAllExams(int id)
        {
            return Ok(_examRepository.GetAllExamsByDrivingSchoolId(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public IActionResult AddExam(Exam examToAdd)
        {
            var wasAddSuccessful = _examRepository.AddExam(examToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("edit")]
        public IActionResult EditExam(Exam editedExam)
        {
            var wasEditSucessful = _examRepository.EditExam(editedExam);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteExam(int id)
        {
            var wasDeleteSucessful = _examRepository.DeleteExam(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetExamById(int id)
        {
            var examToGet = _examRepository.GetExamById(id);

            if(examToGet == null)
                return NotFound();

            return Ok(examToGet);
        }

        [Authorize]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetExamsByStudentId(int id)
        {
            var exams = _examRepository.GetExamsByStudentId(id);

            if(exams == null)
                return NotFound();

            return Ok(exams);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-pass-rate/{id}")]
        public IActionResult GetExamPassRateByExamId(int id)
        {
            var passRate = _examRepository.GetExamPassRateByExamId(id);

            return Ok(passRate);
        }
    }
}