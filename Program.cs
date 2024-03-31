// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

DisplayMessage();
int userOption=ReadUserInput();


Console.WriteLine("Please provide the first input");
int firstInput = int.Parse(Console.ReadLine());
Console.WriteLine("Provide second number");
int b = int.Parse(Console.ReadLine());


int secondInput = int.Parse(Console.ReadLine());

if (userOption == 1)
{
    int sum = firstInput + secondInput;
    //string Interpolation
    Console.WriteLine($"The result is : {sum}");
}
else if (userOption == 2)
{
    int difference = secondInput - firstInput;
    //string Interpolation
    Console.WriteLine($"The result is : {difference}");
}
else if (userOption == 3)
{
    int product = firstInput * secondInput;
    //string Interpolation
    Console.WriteLine($"The result is : {product}");
}
else if (userOption == 4)
{
    int division = firstInput / secondInput;
    //string Interpolation
    Console.WriteLine($"The result is : {division}");
}
else if (userOption == 5)
{
    
    for(int i = firstInput; i < secondInput; i++)
    {
        Console.WriteLine($"{firstInput}*{i}={firstInput * i}");
    }
    
    //productTable
}
DisplayMessage();
ReadUserInput();







int ReadUserInput()
{
    string userInput = Console.ReadLine();
    int userOption = int.Parse(userInput);

    return userOption;
}
void DisplayMessage()
{
    Console.WriteLine("Welcome to Broadway Calculator");
    Console.WriteLine("Please select the below options :");
    Console.WriteLine("1.Addition :");
    Console.WriteLine("2.Subtraction:");
    Console.WriteLine("3.Division :");
    Console.WriteLine("4.Multiplication:");
    Console.WriteLine("5.Product table:");

}










