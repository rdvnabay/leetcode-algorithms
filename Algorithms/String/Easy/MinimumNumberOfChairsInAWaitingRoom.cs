namespace String.Easy;

public static class MinimumNumberOfChairsInAWaitingRoom
{
    public static int Run(string s)
    {
        int counter = 0;
        int max = -1;

        foreach (var c in s)
        {
            if (c == 'E')
                counter++;
            else
                counter--;

            if (counter > max)
                max = counter;
        }

        return max;
    }
}
