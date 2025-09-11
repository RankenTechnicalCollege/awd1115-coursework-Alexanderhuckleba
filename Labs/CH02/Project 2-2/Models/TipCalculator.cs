namespace TipCalculator.Models
{
    public class Tip
    {
        public decimal? MealCost { get; set; }

        public decimal Tip15 => CalculateTip(0.15m);
        public decimal Tip20 => CalculateTip(0.20m);
        public decimal Tip25 => CalculateTip(0.25m);

        private decimal CalculateTip(decimal percent)
        {
            return (MealCost.HasValue && MealCost > 0)
                ? MealCost.Value * percent
                : 0;
        }
    }
}
