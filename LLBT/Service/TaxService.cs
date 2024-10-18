


namespace LLBT.Service
{
    public class TaxService
    {
        public ITaxNotifier _taxNotifier;
        
        
            _taxNotifier = taxNotifier;
        }

        public decimal CalculateTax(decimal salary) { 
                            

            _taxNotifier.Notify(salary, tax);

            return tax;
        
        }

    }
}
