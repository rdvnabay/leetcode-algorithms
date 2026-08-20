/**
 * @id         1221
 * @title      Split a String in Balanced Strings
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/split-a-string-in-balanced-strings/
 */
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


