using System;
namespace Retrovizor.Data.Entities.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Value { get; set; }
    }
}
