// See https://aka.ms/new-console-template for more information

using Calculator_App_Broadway;

Console.WriteLine("Welcome to MyCalculator App");

#region objectInstances
Instruction instruction = new Instruction();
Addition addition = new Addition();
Subtraction subtraction = new Subtraction();
Multiplication multiplication = new Multiplication();
Division divide = new Division();
ReadWrite readWrite = new ReadWrite();

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
        result = CalculateOperation(inputLevel, userInput);

        readWrite.WriteFile(userOption, operationType, inputLevel, userInput, result);
        readWrite.ReadFile();

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

#endregion



#region Methods
int CalculateOperation(string inputLevel, int[] userInput)
{
    try
    {
        if (inputLevel == "1.1")
        {
            if (userOption == 1)
            {
                result = addition.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                result = subtraction.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                result = multiplication.OperationForTwoLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                result = divide.OperationForTwoLevelInput(userInput, result);
            }
        }
        else if (inputLevel == "1.2")
        {
            if (userOption == 1)
            {
                result = addition.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                result = subtraction.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                result = multiplication.OperationForThreeLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                result = divide.OperationForThreeLevelInput(userInput, result);
            }
        }
        else if (inputLevel == "1.3")
        {
            if (userOption == 1)
            {
                result = addition.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 2)
            {
                result = subtraction.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 3)
            {
                result = multiplication.OperationForNLevelInput(userInput, result);
            }
            else if (userOption == 4)
            {
                result = divide.OperationForNLevelInput(userInput, result);
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
    return result;
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
        if (inputs[i] == "Ans")
        {
            inputValue[i] = result;
        }
        else 
        {
            inputValue[i] = int.Parse(inputs[i]);
        }
        

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