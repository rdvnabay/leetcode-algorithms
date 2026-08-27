/**
 * @id         2578
 * @title      Split With Minimum Sum
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/split-with-minimum-sum/
 */
namespace Algorithms.Math.Easy;

public static class SplitWithMinimumSum
{
    public static int Run(int num)
    {
        int total = 0;
        char[] numCharArray = num.ToString().ToCharArray();
        System.Array.Sort(numCharArray);

        if (numCharArray.Length == 2)
            return numCharArray[0] - '0' + numCharArray[1] - '0';

        while (numCharArray.Length > 0)
        {
            if (numCharArray.Length == 1)
            {
                total += numCharArray[0] - '0';
                break;
            }
            else
            {
                total += ((numCharArray[0] - '0') * 10) + (numCharArray[^1] - '0');
                numCharArray = numCharArray[1..^1];
            }
        }

        return total;
    }
}


