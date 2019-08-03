using Retrovizor.Data.Enums;

namespace Retrovizor.Domain.Classes
{
    public class UserCredentials
    {
        public UserCredentials(int id, string username, string password, Role role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
