
using LLBT.BandsClasses;

namespace LLBT.Strategy
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal salary, List<ITaxBand> Bands);
    }
}
