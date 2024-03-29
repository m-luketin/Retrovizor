﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class DrivingSchool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
