using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    internal class Subtraction
    {
        double result;
        public void Subtract(double firstInput,double secondInput)
        {
            result = firstInput - secondInput;
            Console.WriteLine("The subtraction is: " + result);
        }
    }
}
