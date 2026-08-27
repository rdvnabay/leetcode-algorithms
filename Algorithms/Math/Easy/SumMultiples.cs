/**
 * @id         2652
 * @title      Sum Multiples
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-multiples/
 */
namespace Math.Easy;

public static class SumMultiples
{
    //10
    public static int Run(int n)
    {
        int result = 0;

        for (int i = 0; i <= n; i++)
        {
            int counter=0;

            if (i % 3 == 0)
                counter++;

            if (i % 5 == 0)
                counter++;

            if (i % 7 == 0)
                counter++;

            if (counter == 1)
                result += i;
        }

        return result;
    }
}


