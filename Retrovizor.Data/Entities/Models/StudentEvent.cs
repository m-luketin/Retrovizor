using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class StudentEvent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
