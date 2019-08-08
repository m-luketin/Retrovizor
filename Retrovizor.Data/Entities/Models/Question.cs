using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string Picture { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
