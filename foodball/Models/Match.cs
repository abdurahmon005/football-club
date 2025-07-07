namespace foodball.Models
{
    public class Match
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public DateTime MatchDate { get; set; }

        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }

        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }

        public string Status { get; set; } = "scheduled";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

}
