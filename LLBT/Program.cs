using LBTT.BandsFactory;
using LBTT.Input;
using LBTT.Notifier;
using LBTT.Service;
using LBTT.Strategy;

class Program
{
    static void Main()
    {
        ConsoleInput consoleInput = new ConsoleInput();

        ITaxFactory llbtBands = new FelixsTaxes();

        TaxStrategy taxStrategy = new TaxStrategy();

        ConsoleNotifier consoleNotifier = new ConsoleNotifier();
        decimal salary = consoleInput.GetInput();

        var taxService = new TaxService(llbtBands, taxStrategy, consoleNotifier);

        decimal tax = taxService.CalculateTax(salary);


    }

}
