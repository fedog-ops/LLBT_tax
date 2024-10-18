using LBTT.BandsClasses;
using LBTT.BandsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTT.BandsFactory
{
    public class FelixsTaxes : ITaxFactory
    {
        public List<ITaxBand> GetTaxBands()
        {
            return new List<ITaxBand>
        {
            new TaxBand(0, 750000, 0.78m),
            new UpperTaxBand(750001, 0.99m)
        };
        }
    }
}
