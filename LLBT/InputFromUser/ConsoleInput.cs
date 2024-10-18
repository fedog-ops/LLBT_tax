using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLBT.Input
{
    public class ConsoleInput : ITaxInput
    {
        public decimal GetInput()
        {

            Console.Write("Enter your salary: ");
            string input = Console.ReadLine();
            decimal salary = decimal.Parse(input);

            return salary;
        }
    }
}
