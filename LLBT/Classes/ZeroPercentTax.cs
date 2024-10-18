using LLBT.Interface;

namespace LLBT.Classes
{
    public class ZeroPercentTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary)
        { 
            return 0; 
        }
    }
    public class TwoPercentTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal tax = (salary - 145001) * 0.02m;
            return tax;
        }
    }
    public class FivePercentTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal band2 = (salary - 250001) * 0.05m;
            decimal band1 = (250000 - 145001) * 0.02m;

            return band1 + band2;
        }
    }
    public class TenPercentTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal band3 = (salary - 325001) * 0.1m;
            decimal band2 = (325000 - 250001) * 0.05m;
            decimal band1 = (250000 - 145001) * 0.02m;

            return band1 + band2 + band3;
           
        }
    }
    public class TwelvePercentTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal band4 = (salary - 750001) * 0.12m;
            decimal band3 = (750000 - 325001) * 0.1m;
            decimal band2 = (325000 - 250001) * 0.05m;
            decimal band1 = (250000 - 145001) * 0.02m;

            return band1 + band2 + band3 + band4;
        }
    }
}

//145001 - 250000 2%
//250001 - 325000 5%
//325001 -> 750000 10%
//750001 -> + 12 %