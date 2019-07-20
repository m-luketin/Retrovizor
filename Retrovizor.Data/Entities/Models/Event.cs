using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<StudentEvent> StudentEvents { get; set; }
        public string Type { get; set; }
        public DateTime Time { get; set; }
    }
}
