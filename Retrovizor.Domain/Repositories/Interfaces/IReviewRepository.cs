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
        Review GetReviewById(int id);
    }
}
