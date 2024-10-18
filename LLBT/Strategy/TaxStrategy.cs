using LLBT.BandsClasses;

namespace LLBT.Strategy
{
    public class TaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary, List<ITaxBand> Bands)
        {
            decimal total = 0;
            var descendingTaxBands = Bands.OrderByDescending(band => band.Start).ToList();

            foreach (var band in descendingTaxBands)
            {
                if (salary > band.Start)
                {
                    decimal taxableAmount = Math.Min(salary, band.End) - band.Start;
                    total += taxableAmount * band.Rate;

                    Console.WriteLine($"Band: {band.Start} - {band.End} @ {band.Rate * 100}%");
                    Console.WriteLine($"Taxable Amount for this band: £{taxableAmount}");
                    Console.WriteLine($"Tax for this band: £{taxableAmount * band.Rate}");
                }
            }

            return total;
        }
    }
}
