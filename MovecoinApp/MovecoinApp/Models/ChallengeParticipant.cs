using System;

namespace MovecoinApp.Models
{
    public class ChallengeParticipant
    {
        public string UserId { get; set; }
        public string ChallengeId { get; set; }
        public double Score { get; set; }
        public double Stake { get; set; }
        public DateTime JoinedAt { get; set; }
        
        // Added to resolve errors in MovecoinService
        public User User { get; set; }
        public Challenge Challenge { get; set; }
        public ChallengeMetrics Metrics { get; set; }

        public ChallengeParticipant(string userId, string challengeId, double stake)
        {
            UserId = userId;
            ChallengeId = challengeId;
            Stake = stake;
            JoinedAt = DateTime.UtcNow;
            Metrics = new ChallengeMetrics(0, 0, 0);
        }
        
        // Added parameterless constructor for service usage
        public ChallengeParticipant()
        {
            UserId = string.Empty;
            ChallengeId = string.Empty;
            JoinedAt = DateTime.UtcNow;
            Metrics = new ChallengeMetrics(0, 0, 0);
        }
    }
}