using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_APP
{
    internal class Division
    {
        
        public void division()
        {
            Console.WriteLine("Enter a first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2 = int.Parse(Console.ReadLine());

            int div = num1 / num2;
            int rem = num1 % num2;

            Console.WriteLine($"The dividion of {num1} and {num2} is {div}");
            Console.WriteLine($"The remainder of {num1} and {num2} is {rem}");
        }

        public void division(int a, int b)
        {
            int div1 = a / b;
            int rem = a % b;

            Console.WriteLine($"The division of {a} and {b} is {div1}");
            Console.WriteLine($"The remainder of {a} and {b} is {rem}");
        }

    }
}
