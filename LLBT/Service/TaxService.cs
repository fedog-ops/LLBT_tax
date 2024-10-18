using LBTT.BandsClasses;
using LBTT.BandsFactory;
using LBTT.Notifier;
using LBTT.Strategy;

namespace LBTT.Service
{
    public class TaxService
    {

        public ITaxFactory _taxBandsFactory;
        public ITaxStrategy _taxStrategy;
        public ITaxNotifier _taxNotifier;

        public TaxService(ITaxFactory taxBandsFactory, ITaxStrategy taxStrategy, ITaxNotifier taxNotifier)
        {

            _taxBandsFactory = taxBandsFactory;
            _taxStrategy = taxStrategy;
            _taxNotifier = taxNotifier;
        }

        public decimal CalculateTax(decimal salary)
        {

            var bands = _taxBandsFactory.GetTaxBands();

            decimal tax = _taxStrategy.CalculateTax(salary, bands);

            _taxNotifier.Notify(salary, tax);

            return tax;

        }
    }
}