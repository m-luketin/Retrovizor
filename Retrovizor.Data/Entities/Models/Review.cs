using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public string ReviewText { get; set; }
    }
}
