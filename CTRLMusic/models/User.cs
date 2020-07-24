
using System;

namespace CTRLMusic
{
    public class User
    {
        // PROPERTIES

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // CONSTRUCTORS

        public User() { }
        public User(int id, string name, string password, string role, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
