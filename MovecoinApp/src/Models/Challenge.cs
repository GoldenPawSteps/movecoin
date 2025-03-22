using System;
using System.Collections.Generic;

namespace MovecoinApp.Models
{
    public class Challenge
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Metrics Metrics { get; set; }
        public Dictionary<string, double> Scores { get; set; }
        public double Stakes { get; set; }
        public double Rewards { get; set; }
        public TimeSpan Duration { get; set; }

        public Challenge()
        {
            Id = Guid.NewGuid();
            Scores = new Dictionary<string, double>();
        }

        public double CalculateScore()
        {
            double totalScore = 0;
            foreach (var metric in Scores)
            {
                totalScore += metric.Value; // Apply weights if needed
            }
            return totalScore;
        }

        public double CalculateRewards(double organizerProfitMargin)
        {
            double totalPool = Stakes * Scores.Count; // Assuming each participant stakes
            double organizerProfit = totalPool * organizerProfitMargin;
            return (totalPool - organizerProfit) * (CalculateScore() / Scores.Count); // Proportional rewards
        }
    }
}