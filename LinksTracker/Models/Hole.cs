using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}