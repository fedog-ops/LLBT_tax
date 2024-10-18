using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLBT.BandsClasses
{
    public class UpperTaxBand : ITaxBand
    {
        public decimal Start { get; }
        public decimal End { get; }
        public decimal Rate { get; }

        public UpperTaxBand(decimal start, decimal rate)
        {
            Start = start;
            End = decimal.MaxValue;
            Rate = rate;
        }
    }
}
