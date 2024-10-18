
using LBTT.BandsClasses;

namespace LBTT.Strategy
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal salary, List<ITaxBand> Bands);
    }
}
