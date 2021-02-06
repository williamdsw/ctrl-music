
using System;

namespace Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Provider() { }
        public Provider(int id, string name, string identification, Address address, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Identification = identification;
            Address = address;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}