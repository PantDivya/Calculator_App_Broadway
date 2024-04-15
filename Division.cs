using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    internal class Division
    {
        double result;
        public void Divide(double firstInput, double secondInput)
        {
            while (true)
            {
                if (secondInput == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number:");
                    if (!double.TryParse(Console.ReadLine(), out secondInput) || secondInput == 0)
                    {
                        Console.WriteLine("Invalid second number. Please enter a valid non-zero number.");
                        continue;
                    }
                }
                result = firstInput / secondInput;
                Console.WriteLine("The division is: " + result);
                break;
            }
        }
    }
}
