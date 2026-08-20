/**
 * @id         2600
 * @title      K Items With the Maximum Sum
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/k-items-with-the-maximum-sum/
 */
namespace Math.Easy;

public static class KItemsWithTheMaximumSum
{
    //numOnes = 3, numZeros = 2, numNegOnes = 0, k = 2
    public static int Run(int numOnes, int numZeros, int numNegOnes, int k)
    {
        int length = numOnes + numZeros + numNegOnes;
        int[] arr = new int[length];

        for (int i = 0; i < numOnes; i++)
            arr[i] = 1;

        for (int i = numOnes; i < numOnes + numZeros; i++)
            arr[i] = 0;

        for (int i = numOnes + numZeros; i < numOnes + numZeros + numNegOnes; i++)
            arr[i] = -1;

        int total = 0;

        for (int i = 0; i < k; i++)
            total += arr[i];

        return total;
    }
}


