/**
 * @id         941
 * @title      Valid Mountain Array
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/valid-mountain-array/
 */
using System.Text;

namespace Algorithms.Array.Easy;

public static class ValidMountainArray
{
    public static bool Run(int[] arr)
    {
        if (arr.Length < 3)
            return false;

        StringBuilder sb = new();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int current = arr[i];
            int next = arr[i + 1];

            if (current < next)
            {
                if (sb.Length == 0 || sb[sb.Length - 1] == '1')
                    sb.Append(1);
                else
                    return false;
            }

            else if (current > next)
            {
                if (sb.Length == 0)
                    return false;

                sb.Append(0);
            }

            else
            {
                return false;
            }
        }

        if (sb[sb.Length - 1] != '0')
            return false;

        return true;
    }
}

