 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_APP
{
    internal class Subtraction
    {
        public void subtract()
        {
            Console.WriteLine("Enter a first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2 = int.Parse(Console.ReadLine());

            int difference = num1 - num2;

            Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
        }

        public void subtract(int a, int b, int c)
        {
            int diff = a - b - c;

            Console.WriteLine($"The difference of {a}, {b} and {c} is {diff}");
        }
    }
}
