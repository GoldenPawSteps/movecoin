using System;
using System.Collections.Generic;
using System.Linq;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class RewardService
    {
        public decimal CalculateRewards(List<User> participants, Challenge challenge)
        {
            decimal totalPool = CalculateTotalPool(challenge);
            decimal organizerProfit = CalculateOrganizerProfit(totalPool, challenge.Reward.Margin);
            decimal netPool = totalPool - organizerProfit;

            return participants.Sum(user => CalculateUserReward(user, challenge, netPool));
        }

        private decimal CalculateTotalPool(Challenge challenge)
        {
            return challenge.Stakes * challenge.Participants.Count;
        }

        private decimal CalculateOrganizerProfit(decimal totalPool, decimal margin)
        {
            return totalPool * margin;
        }

        private decimal CalculateUserReward(User user, Challenge challenge, decimal netPool)
        {
            decimal userScore = CalculateUserScore(user, challenge);
            decimal totalScore = challenge.Participants.Sum(participant => CalculateUserScore(participant, challenge));

            return (userScore / totalScore) * netPool;
        }

        private decimal CalculateUserScore(User user, Challenge challenge)
        {
            // Assuming user has a method to get their metrics for the challenge
            var userMetrics = user.GetMetricsForChallenge(challenge);
            return (userMetrics.Steps * challenge.Metrics.WeightSteps) +
                   (userMetrics.Floors * challenge.Metrics.WeightFloors) +
                   (userMetrics.IntensityMinutes * challenge.Metrics.WeightIntensityMinutes);
        }
    }
}