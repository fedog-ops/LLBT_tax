using LLBT.Interface;
using LLBT.Classes;

namespace LLBT
{
    public class TaxFactory
    {
        public ITaxStrategy TaxBand(decimal salary)
        {
            if (salary < 140001)
            {
                return new ZeroPercentTax();
            }
            else if (salary < 250001)
            {
                return new TwoPercentTax();
            }
            else if (salary < 325001)
            {
                return new FivePercentTax();
            }
            else if (salary < 750001)
            {
                return new TenPercentTax();
            }

            return new TwelvePercentTax(); 
        }
    }
}
