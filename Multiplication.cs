using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_APP
{
    internal class Multiplication
    {
        public void Multiple()
        {
            Console.WriteLine("Enter a first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2 = int.Parse(Console.ReadLine());

            int Multiple = num1 * num2;

            Console.WriteLine($"The multiple of {num1} and {num2} is {Multiple}");
        }

        public void Multiple(int a, int b, int c)
        {
            int Multiple1 = a * b * c;

            Console.WriteLine($"The multiple of {a}, {b} and {c} is {Multiple1}");
        }
    }
}
