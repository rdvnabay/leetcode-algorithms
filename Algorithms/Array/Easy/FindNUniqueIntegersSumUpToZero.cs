/**
 * @id         1304
 * @title      Find N Unique Integers Sum up to Zero
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
 */
using System.Reflection.Metadata.Ecma335;

namespace Array.Easy;

public static class FindNUniqueIntegersSumUpToZero
{
    public static int[] Run(int n)
    {
        int[] result = new int[n];

        if (n % 2 == 1)
        {
            int num = (n / 2) * -1;

            for (int i = 0; i < n; i++)
            {
                result[i] = num;
                num++;
            }
        }
        else
        {
            int num = (n / 2) * -1;

            for (int i = 0; i < n; i++)
            {
                if (num == 0)
                    num = 1;

                result[i] = num;
                num++;
            }
        }

        return result;
    }
}



