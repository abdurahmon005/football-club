using foodball.Models;
using System.Numerics;

namespace foodball.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; } = null!;
        public DateTime FoundedDate { get; set; }
        public string HomeStadium { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;

        public List<Player> Players { get; set; }


        public ICollection<Match> HomeMatches { get; set; } = new List<Match>();
        public ICollection<Match> AwayMatches { get; set; } = new List<Match>();
    }


}
