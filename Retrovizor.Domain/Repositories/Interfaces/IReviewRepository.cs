using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetAllReviews();
        bool AddReview(Review reviewToAdd);
        bool EditReview(Review editedReview);
        bool DeleteReview(int idOfReviewToDelete);
        Review GetReviewById(int id);
        List<Review> GetReviewsByStudentId(int id);
        List<Review> GetReviewsByInstructorId(int id);
    }
}
