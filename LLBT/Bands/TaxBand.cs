namespace LBTT.BandsClasses
{
    public class TaxBand : ITaxBand
    {
        public decimal Start { get; }
        public decimal End { get; }
        public decimal Rate { get; }

        public TaxBand(decimal start, decimal end, decimal rate)
        {
            Start = start;
            End = end;
            Rate = rate;
        }
    }
}
