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
    public class ExamController : ControllerBase
    {
        public ExamController(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        private readonly IExamRepository _examRepository;

        [HttpGet("all")]
        public IActionResult GetAllExams()
        {
            return Ok(_examRepository.GetAllExams());
        }

        [HttpPost("add")]
        public IActionResult AddExam(Exam examToAdd)
        {
            var wasAddSuccessful = _examRepository.AddExam(examToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [HttpPost("edit")]
        public IActionResult EditExam(Exam editedExam)
        {
            var wasEditSucessful = _examRepository.EditExam(editedExam);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteExam(int id)
        {
            var wasDeleteSucessful = _examRepository.DeleteExam(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [HttpGet("get/{id}")]
        public IActionResult GetExamById(int id)
        {
            var examToGet = _examRepository.GetExamById(id);

            if(examToGet == null)
                return NotFound();

            return Ok(examToGet);
        }
    }
}