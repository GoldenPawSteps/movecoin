public class Metrics
{
    public int Steps { get; set; }
    public int Floors { get; set; }
    public int IntensityMinutes { get; set; }

    public Metrics(int steps, int floors, int intensityMinutes)
    {
        Steps = steps;
        Floors = floors;
        IntensityMinutes = intensityMinutes;
    }

    public int TotalMetrics()
    {
        return Steps + Floors + IntensityMinutes;
    }
}