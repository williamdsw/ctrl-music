
using System;

namespace Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Employee() {}
        public Employee(int id, string name, string identification, string phoneNumber, string email, string role, DateTime birthDate, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Identification = identification;
            PhoneNumber = phoneNumber;
            Email = email;
            Role = role;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}