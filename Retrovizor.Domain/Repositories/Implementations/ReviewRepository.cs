using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
        public ReviewRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;
        public List<Review> GetAllReviews()
        {
            return _context.Reviews.ToList();
        }
        public bool AddReview(Review reviewToAdd)
        {
            var doesReviewExist = _context.Reviews.Any(e =>
                string.Equals(e.ReviewText, reviewToAdd.ReviewText));

            if(doesReviewExist)
                return false;

            _context.Reviews.Add(reviewToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditReview(Review editedReview)
        {
            var reviewToEdit = _context.Reviews.Find(editedReview.Id);

            if(reviewToEdit == null)
                return false;

            reviewToEdit.ReviewText = editedReview.ReviewText;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteReview(int idOfReviewToDelete)
        {
            var reviewToDelete = _context.Reviews.Find(idOfReviewToDelete);

            if(reviewToDelete == null)
                return false;

            _context.Remove(reviewToDelete);
            _context.SaveChanges();
            return true;
        }
        public Review GetReviewById(int id)
        {
            return _context.Reviews.Find(id);
        }

        public List<Review> GetReviewsByStudentId(int id)
        {
            return _context.Reviews.Where(r => r.StudentId == id).ToList();
        }

        public List<Review> GetReviewsByInstructorId(int id)
        {
            return _context.Reviews.Where(r => r.InstructorId == id).ToList();
        }
    }
}
