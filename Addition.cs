namespace Calculator_App_Broadway;

internal class Addition
{
    public int OperationForTwoLevelInput(int[] userInput, int result)
    {
        try
        {
            for (int i = 0; i < 2; i++)
            {
                result += userInput[i];
            }
            Console.WriteLine($"The sum of given two number of inputs: {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return result;
    }
    public int OperationForThreeLevelInput(int[] userInput, int result)
    {
        try
        {
            for (int i = 0; i < 3; i++)
            {
                result += userInput[i];
            }
            Console.WriteLine($"The sum of given three number of inputs: {result}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return result;
    }
    public int OperationForNLevelInput(int[] userInput, int result)
    {
        try
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                result += userInput[i];
            }
            Console.WriteLine($"The sum of given {userInput.Length} number of inputs: {result}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return result;
    }
}
