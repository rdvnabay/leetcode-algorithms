namespace String.Easy;

public static class SplitAStringInBalancedStrings
{
    public static int Run(string s)
    {
        int leftCount = 0;
        int rightCount = 0;
        int counter = 0;

        foreach (var letter in s)
        {
            if (letter == 'L')
                leftCount++;

            else if (letter == 'R')
                rightCount++;

            if (leftCount == rightCount)
            {
                counter++;
                leftCount = 0;
                rightCount = 0;
            }
        }

        return counter;
    }
}
