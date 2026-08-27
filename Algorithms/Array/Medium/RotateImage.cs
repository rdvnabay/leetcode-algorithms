/**
 * @id         48
 * @title      Rotate Image
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/rotate-image/
 */
namespace Algorithms.Array.Medium;

public static class RotateImage
{
    public static void Run(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int left = 0;
        int right = rows - 1;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
            }
        }

        while (left < right)
        {
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
            }
            left++;
            right--;
        }
    }
}


