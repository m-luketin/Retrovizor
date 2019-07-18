using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; }
        public int TotalPoints { get; set; }
        public string Type { get; set; }
    }
}
