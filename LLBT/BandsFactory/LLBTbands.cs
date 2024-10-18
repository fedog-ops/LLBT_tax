using LLBT.BandsClasses;


namespace LLBT.BandsFactory
{
    public class LLBTTaxBands : ITaxFactory
    {
        public List<ITaxBand> GetTaxBands()
        {
            return new List<ITaxBand>
        {
            new TaxBand(0, 145000, 0m),
            new TaxBand(145001, 250000, 0.02m),
            new TaxBand(250001, 325000, 0.05m),
            new TaxBand(325001, 750000, 0.10m),
            new UpperTaxBand(750001, 0.12m)
        };
        }
    }
}
