using System;
using System.Collections.Generic;
using System.Text;
using Retrovizor.Data.Enums;

namespace Retrovizor.Data.Entities.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
