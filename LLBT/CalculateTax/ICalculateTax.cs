
using LBTT.BandsClasses;

namespace LBTT.Strategy
{
    public interface ICalculateTax
    {
        decimal CalculateTax(decimal salary, List<ITaxBand> Bands);
    }
}
