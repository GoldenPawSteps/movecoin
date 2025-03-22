using System;

namespace MovecoinApp.Services
{
    public class MetricsService
    {
        public int CalculateTotalMetrics(int steps, int floors, int intensityMinutes)
        {
            return steps + floors + intensityMinutes;
        }

        public double CalculateWeightedScore(int steps, int floors, int intensityMinutes, double stepsWeight, double floorsWeight, double intensityWeight)
        {
            return (steps * stepsWeight) + (floors * floorsWeight) + (intensityMinutes * intensityWeight);
        }

        public double CalculateAverageMetrics(int totalMetrics, int numberOfChallenges)
        {
            if (numberOfChallenges == 0) return 0;
            return (double)totalMetrics / numberOfChallenges;
        }
    }
}