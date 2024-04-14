using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_APP
{
    internal class Addition
    {
        public void add()
        {
            Console.WriteLine("Enter a first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            int num2 = int.Parse(Console.ReadLine());


            int sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }

        public void add(int a, int b, int c)
        {
            int sum1 = a+ b + c;

            Console.WriteLine($"The sum of {a}, {b} and {c} is {sum1}");
        }

        
    }
}
