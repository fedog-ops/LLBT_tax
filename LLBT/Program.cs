using LLBT.BandsFactory;
using LLBT.Input;
using LLBT.Notifier;
using LLBT.Service;
using LLBT.Strategy;

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