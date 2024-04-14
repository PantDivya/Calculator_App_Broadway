using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        private void UserMessage(string message)
        {
            Console.Write(message);
        }

        private string GetInput()
        {
            string output = Console.ReadLine();
            return output;
        }

        private void GetVal()
        {
            bool isEnteredTwoNumber = false;

            if (FirstNumber != 0 && SecondNumber != 0)
            {
                isEnteredTwoNumber = true;
            }

            if (isEnteredTwoNumber == false)
            {
                UserMessage("Enter 1st number:");
                string value1 = GetInput();
                UserMessage("Enter 2nd number:");
                string value2 = GetInput();
                Console.WriteLine();
                SetVal(ConvertToDouble(value1), ConvertToDouble(value2));
            }
            else
            {
                UserMessage("You already enter maximum number.");
            }
        }

        private void SetVal(double val1, double val2)
        {
            FirstNumber = val1;
            SecondNumber = val2;
        }

        private double ConvertToDouble(string value)
        {
            bool isParseAble = double.TryParse(value, out double output);
            return output;
        }

        private List<double> GetValAsList()
        {
            List<double> output = new List<double>();
            string input = "";

            bool isInput = true;

            do
            {
                UserMessage("Enter number:");
                UserMessage("\n");
                input = GetInput();
                if (input.ToLower() == "no")
                {
                    isInput = false;
                }
                else
                {
                    bool parseAble = double.TryParse(input, out double result);
                    if (parseAble)
                    {
                        output.Add(result);
                    }
                    else
                    {
                        UserMessage("Please provide valid number.");
                    }
                }
            }
            while (isInput == true);

            return output;
        }

        public void MultiplicationTable()
        {
            List<double> values = GetValAsList();
            for (int i = 0; i < values.Count; i++)
            {

                for (double j = 1; j <= 10; j++)
                {
                    double val = values[i];
                    double output = val * j;
                    UserMessage($"{val} * {j} = {output}\n");
                }
                UserMessage("\n");
            }
        }

        private double Add()
        {
            GetVal();
            return FirstNumber + SecondNumber;
        }

        private double Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        private double Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        private double Divide()
        {
            return FirstNumber / SecondNumber;
        }

        public void DisplayResult()
        {
            double result = 0;
            result = Add();
            UserMessage($"Addition of {FirstNumber} and {SecondNumber} is: {result}\n");

            result = Subtract();
            UserMessage($"Subtraction of {FirstNumber} and {SecondNumber} is: {result}\n");

            result = Multiply();
            UserMessage($"Multiplication of {FirstNumber} and {SecondNumber} is: {result}\n");

            result = Divide();
            UserMessage($"Division of {FirstNumber} and {SecondNumber} is: {result}\n");
        }
    }
}
