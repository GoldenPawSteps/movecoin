using System;
using System.Collections.Generic;
using System.Linq;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class ChallengeService
    {
        private readonly List<Challenge> challenges = new List<Challenge>();

        public void CreateChallenge(string name, ChallengeMetrics metrics, decimal stakes, decimal margin, TimeSpan duration, DateTime startDate)
        {
            var challenge = new Challenge
            {
                Name = name,
                // Fix: Create a new list and add the metrics to it
                Metrics = new List<ChallengeMetrics> { metrics },
                Stakes = stakes,
                Margin = margin,
                StartDate = startDate,
                Duration = duration,
                // Convert decimal to double for consistency
                FixedStake = (double)stakes,
                OrganizerProfitMargin = (double)margin,
                Participants = new List<ChallengeParticipant>()
            };

            challenges.Add(challenge);
        }

        public List<Challenge> GetChallenges()
        {
            return challenges;
        }

        public void JoinChallenge(string challengeName, User user, decimal stake)
        {
            var challenge = challenges.FirstOrDefault(c => c.Name == challengeName);
            if (challenge != null)
            {
                var participant = new ChallengeParticipant
                {
                    User = user,
                    // Fix: Convert decimal to double
                    Stake = (double)stake,
                    Score = 0 // Initial score can be set to 0
                };

                challenge.Participants.Add(participant);
            }
        }

        public void UpdateParticipantScore(string challengeName, User user, decimal score)
        {
            var challenge = challenges.FirstOrDefault(c => c.Name == challengeName);
            if (challenge != null)
            {
                var participant = challenge.Participants.FirstOrDefault(p => p.User.Username == user.Username);
                if (participant != null)
                {
                    // Fix: Convert decimal to double before adding
                    participant.Score += (double)score;
                }
            }
        }

        public decimal CalculateRewards(string challengeName)
        {
            var challenge = challenges.FirstOrDefault(c => c.Name == challengeName);
            if (challenge != null)
            {
                // Fix: Convert double to decimal
                decimal totalPool = challenge.Participants.Sum(p => (decimal)p.Stake);
                decimal totalScores = challenge.Participants.Sum(p => (decimal)p.Score);
                decimal organizerProfit = totalPool * challenge.Margin;

                return (totalPool - organizerProfit) / totalScores; // Reward per score
            }

            return 0;
        }

        // Add missing method referenced in ChallengeDetailsViewModel
        public Challenge GetChallengeById(int challengeId)
        {
            // Temporary implementation
            return challenges.FirstOrDefault();
        }
    }
}