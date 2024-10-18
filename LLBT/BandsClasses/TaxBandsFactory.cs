using LLBT.BandsFactory;
namespace LLBT.BandsClasses
{
    public class TaxBandsFactory
    {
        private readonly ITaxFactory _taxBandProvider;

        public TaxBandsFactory(ITaxFactory taxBandProvider)
        {
            _taxBandProvider = taxBandProvider;
        }
        public List<ITaxBand> GetTaxBands()
        {
            return _taxBandProvider.GetTaxBands();
        }
       
    }
}
