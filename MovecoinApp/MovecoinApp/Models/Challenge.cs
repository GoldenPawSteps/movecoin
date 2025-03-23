using System;
using System.Collections.Generic;

namespace MovecoinApp.Models
{
    public class Challenge
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public List<ChallengeMetrics> Metrics { get; set; }
        public Dictionary<string, double> Weights { get; set; }
        public double FixedStake { get; set; }
        public (double Min, double Max)? VariableStake { get; set; }
        public double OrganizerProfitMargin { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPool { get; set; }
        public double Rewards { get; set; }
        public List<ChallengeParticipant> Participants { get; set; }
        public double TotalScore { get; set; }
        
        // Added to resolve errors in ChallengeService
        public decimal Stakes { get; set; }
        public decimal Margin { get; set; }

        public Challenge()
        {
            Metrics = new List<ChallengeMetrics>();
            Weights = new Dictionary<string, double>();
            Participants = new List<ChallengeParticipant>();
        }

        public double CalculateScore(ChallengeMetrics metrics)
        {
            double score = 0;
            
            if (metrics.Steps > 0 && Weights.TryGetValue("Steps", out double stepsWeight))
                score += metrics.Steps * stepsWeight;
                
            if (metrics.Floors > 0 && Weights.TryGetValue("Floors", out double floorsWeight))
                score += metrics.Floors * floorsWeight;
                
            if (metrics.IntensityMinutes > 0 && Weights.TryGetValue("IntensityMinutes", out double intensityWeight))
                score += metrics.IntensityMinutes * intensityWeight;
                
            return score;
        }

        public double CalculateRewards(double totalScore)
        {
            double totalStake = FixedStake;
            double profit = totalStake * OrganizerProfitMargin;
            return totalScore > 0 ? (totalScore / (TotalPool - profit)) * totalStake : 0;
        }
    }
}