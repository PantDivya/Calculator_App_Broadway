using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    internal class Addition
    {
        double result;
        public void Add(double firstInput, double secondInput)
        {           
            result = firstInput + secondInput;
            Console.WriteLine("The addition is: " + result);
        }    
    }
}
