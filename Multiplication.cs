using System;
namespace Calculator_App_Broadway
{
	public class Multiplication
	{
		public Multiplication(int a,int b)
		{
		
                int product = a * b;
                Console.WriteLine("Result: " + product);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
           int  num1 = 10;
           int  num2 = 10;
           Multiplication mul = new Multiplication(num1,num2);

            }
        }
    }



