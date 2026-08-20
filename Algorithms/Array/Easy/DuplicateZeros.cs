/**
 * @id         1089
 * @title      Duplicate Zeros
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/duplicate-zeros/
 */
namespace Algorithms.Array.Easy;

public static class DuplicateZeros
{
    public static void Run(int[] arr)
    {
        int skipIndex = -1;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 0 && i != skipIndex)
            {
                skipIndex = i + 1;
                for (int j = arr.Length - 2; j > i; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[i + 1] = 0;
            }
        }
    }
}


