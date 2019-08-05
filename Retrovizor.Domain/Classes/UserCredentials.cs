using Retrovizor.Data.Enums;

namespace Retrovizor.Domain.Classes
{
    public class UserCredentials
    {
        public UserCredentials(int id, string username, string password, Role role, int drivingSchoolId)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
            DrivingSchoolId = drivingSchoolId;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int DrivingSchoolId { get; set; }
    }
}
