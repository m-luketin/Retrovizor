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
    public class ReviewController : ControllerBase
    {
        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        private readonly IReviewRepository _reviewRepository;

        [Authorize(Roles = "Student")]
        [HttpPost("add")]
        public IActionResult AddReview(Review reviewToAdd)
        {
            var wasAddSuccessful = _reviewRepository.AddReview(reviewToAdd);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }

        [Authorize(Roles = "Student")]
        [HttpPost("edit")]
        public IActionResult EditReview(Review editedReview)
        {
            var wasEditSucessful = _reviewRepository.EditReview(editedReview);

            if(wasEditSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Student")]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteReview(int id)
        {
            var wasDeleteSucessful = _reviewRepository.DeleteReview(id);

            if(wasDeleteSucessful)
                return Ok();

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetReviewById(int id)
        {
            var reviewToGet = _reviewRepository.GetReviewById(id);

            if(reviewToGet == null)
                return NotFound();

            return Ok(reviewToGet);
        }

        [Authorize(Roles = "Admin, Student")]
        [HttpGet("get-by-student/{id}")]
        public IActionResult GetReviewsById(int id)
        {
            var reviewsToGet = _reviewRepository.GetReviewsByStudentId(id);

            if(reviewsToGet == null)
                return NotFound();

            return Ok(reviewsToGet);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("get-by-instructor/{id}")]
        public IActionResult GetReviewsByInstructorId(int id)
        {
            var reviewToGet = _reviewRepository.GetReviewsByInstructorId(id);

            if(reviewToGet == null)
                return NotFound();

            return Ok(reviewToGet);
        }
    }
}