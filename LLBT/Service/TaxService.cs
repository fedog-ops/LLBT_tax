

using LLBT.Interface;

namespace LLBT.Service
{
    public class TaxService
    {
        public TaxFactory _taxFactory;
        public ITaxNotifier _taxNotifier;
        
        public TaxService(TaxFactory taxFactory, ITaxNotifier taxNotifier) {
        
            _taxFactory = taxFactory;
            _taxNotifier = taxNotifier;
        }

        public decimal CalculateTax(decimal salary) { 
                            
            ITaxStrategy strategy = _taxFactory.TaxBand(salary);
            decimal tax = strategy.CalculateTax(salary);

            _taxNotifier.Notify(salary, tax);

            return tax;
        
        }

    }
}
