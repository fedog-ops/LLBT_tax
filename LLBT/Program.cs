using LLBT.Service;

class Program
{
    static void Main()
    {
        TaxFactory taxFactory = new TaxFactory();
        ConsoleNotifier consoleNotifier = new ConsoleNotifier();
        ConsoleInput consoleInput = new ConsoleInput(); 

        ITaxFactory llbtBands = new FelixsTaxes();
        
        TaxStrategy taxStrategy = new TaxStrategy();
        
        ConsoleNotifier consoleNotifier = new ConsoleNotifier();
        decimal salary = consoleInput.GetInput();
        

        decimal tax = taxService.CalculateTax(salary);
     



    }

}