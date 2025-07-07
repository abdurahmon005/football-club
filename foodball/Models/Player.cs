using System.ComponentModel.DataAnnotations;

namespace foodball.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public string Position { get; set; } = null!;
        public int? JerseyNumber { get; set; }

        public int TeamId { get; set; }
        public Team? Team { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
