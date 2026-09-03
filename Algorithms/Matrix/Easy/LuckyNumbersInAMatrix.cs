/**
 * @id         1380
 * @title      Lucky Numbers in a Matrix
 * @topic      Matrix
 * @difficulty Easy
 * @link       https://leetcode.com/problems/lucky-numbers-in-a-matrix/
 */
namespace Matrix.Easy;

public static class LuckyNumbersInAMatrix
{
    public static IList<int> Run(int[][] matrix)
    {
        int rows = matrix.Length; 
        int cols = matrix[0].Length;
        List<int> result = new();

        for (int i = 0; i < rows; i++)
        {
            int minRowValue = int.MaxValue;
            int findColumnIndex = 0;

            for (int j = 0; j < cols; j++)
            {
                int value = matrix[i][j];
                if (value < minRowValue)
                {
                    minRowValue = value;
                    findColumnIndex = j;
                }
            }

            bool isColumnMaximum = true;
            for (int k = 0; k < rows; k++)
            {
                if (minRowValue < matrix[k][findColumnIndex])
                {
                    isColumnMaximum = false;
                    break;
                }
            }

            if (isColumnMaximum)
                result.Add(minRowValue);
        }

        return result;
    }
}
