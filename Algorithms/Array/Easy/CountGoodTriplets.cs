/**
 * @id         1534
 * @title      Count Good Triplets
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-good-triplets/
 */
namespace Array.Easy;

public static class CountGoodTriplets
{
    public static int Run(int[] arr, int a, int b, int c)
    {
        int total = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a &&
                        Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        total++;
                    }
                }
            }
        }

        return total;
    }
}


