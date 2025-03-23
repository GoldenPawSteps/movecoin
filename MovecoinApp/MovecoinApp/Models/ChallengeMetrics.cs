using System;

namespace MovecoinApp.Models
{
    public class ChallengeMetrics
    {
        public int Steps { get; set; }
        public int Floors { get; set; }
        public int IntensityMinutes { get; set; }

        public ChallengeMetrics(int steps, int floors, int intensityMinutes)
        {
            Steps = steps;
            Floors = floors;
            IntensityMinutes = intensityMinutes;
        }
    }
}