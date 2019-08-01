using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public int TotalLessons { get; set; }
        public string Type { get; set; }
    }
}
