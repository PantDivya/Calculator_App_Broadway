// See https://aka.ms/new-console-template for more information

using Calculator_App_Broadway;

Console.WriteLine("Welcome to MyCalculator App");

#region objectInstances
Instruction instruction = new Instruction();
Addition addition = new Addition();
Subtraction subtraction = new Subtraction();
Multiplication multiplication = new Multiplication();
Division divide = new Division();

#endregion

#region performOperation
int result = 0;
string operationType = "";
int userOption;
string inputLevel;
int[] userInput;



bool userOperation = true;
while (userOperation)
{
    try
    {
        instruction.GetCoreInstruction();
        //method call for user input for selecting operation 
        userOption = ReadUserInputOperation();
        //condition for exit
        if (userOption == 6)
        {
            break;
        }
        string operation = ReturnOperationType(userOption);
        instruction.GetSubCoreInstruction(operation);

        inputLevel = ReadUserInputlevel();

        userInput = UserInputForOperation(inputLevel);

        //method call for calculation 
        CalculateOperation(inputLevel, userInput);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

#endregion



#region Methods
void CalculateOperation(string inputLevel, int[] userInput)
{
    try
    {
        if (inputLevel == "1.1")
        {
            if (userOption == 1)
            {
                addition.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                subtraction.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                multiplication.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                divide.OperationForTwoLevelInput(userInput, result);
            }
        }
        else if (inputLevel == "1.2")
        {
            if (userOption == 1)
            {
                addition.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                subtraction.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                multiplication.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                divide.OperationForThreeLevelInput(userInput, result);
            }
        }
        else if (inputLevel == "1.3")
        {
            if (userOption == 1)
            {
                addition.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                subtraction.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                multiplication.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                divide.OperationForNLevelInput(userInput, result);
            }
        }
        else
        {
            Console.WriteLine("Invalid Selection");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}

int ReadUserInputOperation()
{
    int operation = int.Parse(Console.ReadLine());
    return operation;
}

string ReadUserInputlevel()
{
    string inputLevel = Console.ReadLine();
    return inputLevel;
}
string ReturnOperationType(int userOption)
{
    try
    {
        //select operation and show instruction for level of input
        if (userOption == 1)
        {
            operationType = "Addition";
        }
        else if (userOption == 2)
        {
            operationType = "Subtraction";
        }
        else if (userOption == 3)
        {
            operationType = "Multiplication";
        }
        else if (userOption == 4)
        {
            operationType = "Division";
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    return operationType;
}
int[] GetTwoLevelInput()
{
    //Two level of input 
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for (int i = 0; i < 2; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);

    }
    return inputValue;
}

int[] GetThreeLevelInput()
{
    //Three level of input
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for (int i = 0; i < 3; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);
    }
    return inputValue;
}
int[] GetNNumberOfInput()
{
    //Read n number of input
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for (int i = 0; i < inputs.Length; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);

    }
    return inputValue;

}


int[] UserInputForOperation(string inputLevel)
{
    int[] UserInput = new int[0];
    try
    {
        if (inputLevel == "1.1")
        {
            Console.WriteLine("get 2 level input");
            UserInput = GetTwoLevelInput();
        }
        else if (inputLevel == "1.2")
        {
            Console.WriteLine("get 3 level input");
            UserInput = GetThreeLevelInput();
        }
        else if (inputLevel == "1.3")
        {
            Console.WriteLine("get n level of input");
            UserInput = GetNNumberOfInput();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    return UserInput;
}
#endregion