// See https://aka.ms/new-console-template for more information
//Homework 
//ADD, Subtract , Division , Multiplication
using Calculator_APP;
using System;
using System.Numerics;

Console.WriteLine("Welcome to Calculator");
//DisplayMessage();
#region PerformCalculation
bool UserConsent = true;

while (UserConsent)
{
    int UserInput = ReadUserInput();
    CalculateOperation(UserInput);
    UserConsent = IsUserConsent();
    break;
}
#endregion




bool IsUserConsent(){
    Console.WriteLine("Do you wanna perform another operation?");
    Console.WriteLine("Enter 'y' to continue 'n' to exit");
    string userOpt = Console.ReadLine();
    if (userOpt == "y" || userOpt == "Y")
    {
        return true;
    }
    else
    {  
        return false;
    }
}

int ReadUserInput()
{
    //int UserOutput;
    DisplayMessage();
    Console.WriteLine("Enter option");

    string UserInput = Console.ReadLine();
    //int UserOption = int.Parse(UserInput);

    int.TryParse(UserInput, out int UserOutput);

    return UserOutput;

}

// use reference for answer.

void DisplayMessage()
{
    Console.WriteLine("Choose a mathematical calculation :");
    Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
}

void CalculateOperation(int UserOption)
{
    if (UserOption == 1)
    {
        Console.WriteLine("Choose either parameterised (p) or non-parameterised (n)");
        string option = Console.ReadLine();
        if (option == "P" || option == "p")
        {
            Addition addition = new Addition();
            addition.add(3, 4, 5);
        }
        else
        {
            Addition addition = new Addition();
            addition.add();

        }




    }
    else if (UserOption == 2)
    {
        Console.WriteLine("Choose either parameterised (p) or non-parameterised (n)");
        string option = Console.ReadLine();
        if (option == "P" || option == "p")
        {
            Subtraction subtract = new Subtraction();
            subtract.subtract(7,6,3);
        }
        else
        {
            Subtraction subtract = new Subtraction();
            subtract.subtract();

        }
        


    }
    else if (UserOption == 3)
    {
        Console.WriteLine("Choose either parameterised (p) or non-parameterised (n)");
        string option = Console.ReadLine();
        if (option == "P" || option == "p")
        {
            Multiplication multiple = new Multiplication();
            multiple.Multiple(6,7,8);
        }
        else
        {
            Multiplication multiple = new Multiplication();
            multiple.Multiple();

        }
        

    }
    else if (UserOption == 4)
    {
        Console.WriteLine("Choose either parameterised (p) or non-parameterised (n)");
        string option = Console.ReadLine();
        if (option == "P" || option == "p")
        {
            Division divide = new Division();
            divide.division(12,6);
        }
        else
        {
            Division divide = new Division();
            divide.division();

        }
        
    }
}



