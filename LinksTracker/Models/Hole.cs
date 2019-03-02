using System;
using System.ComponentModel.DataAnnotations;

namespace LinksTracker.Models
{
    public class Hole
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int CourseId { get; set; }
        public int Yardage { get; set; }
        public int Par { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}