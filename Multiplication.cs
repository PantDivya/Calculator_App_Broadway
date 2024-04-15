using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    internal class Multiplication
    {
        double result;
        public void Multiply(double firstInput, double secondInput)
        {
            result = firstInput * secondInput;
            Console.WriteLine("The multiplication is: " + result);
        }
    }
}
