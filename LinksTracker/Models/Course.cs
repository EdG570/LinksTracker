using System;
using System.ComponentModel.DataAnnotations;

namespace LinksTracker.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Par { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Rating { get; set; }
        public double Slope { get; set; }
        public int TotalHoles { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        // public virtual ICollection<Hole> Holes { get; set; }
    }
}