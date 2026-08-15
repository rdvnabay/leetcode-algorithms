namespace String.Easy;

public static class FinalValueOfVariableAfterPerformingOperations
{
    public static int Run(string[] operations)
    {
        int counter = 0;

        foreach (var operation in operations)
        {
            foreach (var item in operation)
            {
                if (item == '+')
                {
                    counter++;
                    break;
                }
                else if (item == '-')
                {
                    counter--;
                    break;
                }
            }
        }

        return counter;
    }
}
