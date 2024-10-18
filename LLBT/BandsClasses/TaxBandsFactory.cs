using LLBT.BandsFactory;
namespace LLBT.BandsClasses
{
    public class TaxBandsFactory
    {
        private readonly ITaxFactory _taxBand;

        public TaxBandsFactory(ITaxFactory taxBand)
        {
            _taxBand = taxBand;
        }
        public List<ITaxBand> GetTaxBands()
        {
            return _taxBand.GetTaxBands();
        }
       
    }
}
