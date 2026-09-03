/**
 * @id         2643
 * @title      Row With Maximum Ones
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/row-with-maximum-ones/
 */
namespace Array.Easy;

public static class RowWithMaximumOnes
{
    public static int[] Run(int[][] mat)
    {
        int rowIndex = 0;
        int maxOnesCount = 0;

        for (int i = 0; i < mat.Length; i++)
        {
            int onesCount = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                    onesCount++;
            }

            if (onesCount > maxOnesCount)
            {
                maxOnesCount = onesCount;
                rowIndex = i;
            }
        }

        return [rowIndex, maxOnesCount];
    }
}
