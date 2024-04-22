namespace Calculator_App_Broadway;

internal class Division
{

    public int OperationForTwoLevelInput(int[] userInput, int result)
    {
        try
        {
            for (int i = 0; i < 2; i++)
            {
                result = userInput[0] / userInput[1];
            }
            Console.WriteLine($"The division of given two number of inputs: {result}");

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
                result = userInput[0] / userInput[1] / userInput[2];
            }
            Console.WriteLine($"The division of given three number of inputs: {result}");
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
            int n = userInput.Length;
            result = userInput[0];
            for (int i = 1; i < n; i++)
            {
                result /= userInput[i];
            }
            Console.WriteLine($"The division of given {n} number of inputs: {result}");

        }
        catch (Exception e)
        {

            Console.WriteLine(e);
        }
        return result;
    }

}
