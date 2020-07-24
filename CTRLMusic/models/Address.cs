
using System;

namespace CTRLMusic
{
    public class Address
    {
        // PROPERTIES

        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // CONSTRUCTORS

        public Address() {}
        public Address(int id, string street, string number, string complement, string zipCode, string city, string state, string country, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
