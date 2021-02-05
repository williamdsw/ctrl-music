
using System;

namespace Model
{
    public class Measures
    {
        public int Id { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Measures() { }
        public Measures(int id, double height, double width, double weight, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Height = height;
            Width = width;
            Weight = weight;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}