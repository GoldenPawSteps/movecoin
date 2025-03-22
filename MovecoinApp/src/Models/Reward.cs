public class Reward
{
    public decimal TotalPool { get; set; }
    public decimal OrganizerProfit { get; set; }
    public decimal Margin { get; set; }

    public decimal CalculateFinalRewards(decimal scores, decimal stakes)
    {
        decimal netPool = TotalPool - OrganizerProfit;
        return (scores / stakes) * netPool * (1 - Margin);
    }
}