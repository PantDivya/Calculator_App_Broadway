// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
Console.WriteLine("Welcome to Broadway Calculator");
DisplayMessage();
#region PerformOperation
bool userConsent = true;

while (userConsent)
{
    int userOption = ReadUserInput();
    #region GetUserInput
    Console.WriteLine("Please provide the first input");
    int firstInput = int.Parse(Console.ReadLine());

    //statement
    Console.WriteLine("Please provide the second  input");

    int secondInput = int.Parse(Console.ReadLine());
    #endregion
    CalculateOperation(userOption,firstInput,secondInput);
    userConsent = IsUserConsent();
}
#endregion


bool IsUserConsent(){
    Console.WriteLine("Do you want to perform another operation?");
    bool isUserC=Console.ReadLine();
}
void  CalculateOperation(int userOption,int firstInput,int secondInput)
{

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

        for (int i = firstInput; i < secondInput; i++)
        {
            Console.WriteLine($"{firstInput}*{i}={firstInput * i}");
        }

        //productTable
    }

}
int ReadUserInput()
{
    string userInput = Console.ReadLine();
    return  int.Parse(userInput);
}
void DisplayMessage()
{
    try
    {
        
        Console.WriteLine("Please select the below options :");
        Console.WriteLine("1.Addition :");
        Console.WriteLine("2.Subtraction:");
        Console.WriteLine("3.Division :");
        Console.WriteLine("4.Multiplication:");
        Console.WriteLine("5.Product table:");
    }
    catch (Exception)
    {

        throw;
    }
   

}



//Add
//Su
//DD
//MM

//Add
//









