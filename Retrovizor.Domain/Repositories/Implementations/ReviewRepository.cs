using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
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
        ReviewRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Review> GetAllReviews()
        {
            return _context.Reviews.ToList();
        }

        public Review GetReviewById(int id)
        {
            return _context.Reviews.Find(id);
        }
    }
}
