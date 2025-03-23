using System;
using System.Collections.Generic;
using System.Linq;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class MovecoinService
    {
        private readonly List<Challenge> _challenges;

        public MovecoinService()
        {
            _challenges = new List<Challenge>();
        }

        public void CreateChallenge(Challenge challenge)
        {
            _challenges.Add(challenge);
        }

        public void DistributeRewards(Challenge challenge)
        {
            var totalPool = challenge.Participants.Sum(p => p.Stake);
            // Use OrganizerProfitMargin instead of OrganizerMargin
            var organizerProfit = totalPool * challenge.OrganizerProfitMargin;
            var rewardPool = totalPool - organizerProfit;

            foreach (var participant in challenge.Participants)
            {
                var score = CalculateScore(participant);
                var reward = (score / challenge.TotalScore) * rewardPool;
                // User doesn't have MovecoinWallet - update User's balance directly
                participant.User.AddMovecoins((int)reward);
            }
        }

        private double CalculateScore(ChallengeParticipant participant)
        {
            double score = 0;

            // Use Challenge.Weights instead of MetricsWeights
            if (participant.Metrics.Steps > 0 && 
                participant.Challenge.Weights.TryGetValue("Steps", out double stepsWeight))
            {
                score += participant.Metrics.Steps * stepsWeight;
            }
            
            if (participant.Metrics.Floors > 0 && 
                participant.Challenge.Weights.TryGetValue("Floors", out double floorsWeight))
            {
                score += participant.Metrics.Floors * floorsWeight;
            }
            
            if (participant.Metrics.IntensityMinutes > 0 && 
                participant.Challenge.Weights.TryGetValue("IntensityMinutes", out double intensityWeight))
            {
                score += participant.Metrics.IntensityMinutes * intensityWeight;
            }

            return score;
        }
    }
}