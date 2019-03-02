using System;

namespace LinksTracker.Models
{
    public class Stats
    {
        public int Id { get; set; }
        public bool FIR { get; set; }
        public bool GIR { get; set; }
        public bool UpAndDown { get; set; }
        public int Putts { get; set; }
        public int Penalties { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int HoleId { get; set; }
        public int UserId { get; set; }

        public virtual Hole Hole { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}