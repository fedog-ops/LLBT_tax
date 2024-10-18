
using LLBT;
using LLBT.Classes;
using LLBT.Interface;
using LLBT.Service;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        TaxFactory taxFactory = new TaxFactory();
        ConsoleNotifier consoleNotifier = new ConsoleNotifier();
        ConsoleInput consoleInput = new ConsoleInput(); 

        decimal salary = consoleInput.GetInput();
        
        var taxService = new TaxService(taxFactory, consoleNotifier);

        decimal tax = taxService.CalculateTax(salary);
     
    }

}