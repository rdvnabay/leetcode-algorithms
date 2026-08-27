/**
 * @id         766
 * @title      Toeplitz Matrix
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/toeplitz-matrix/
 */
namespace Algorithms.Array.Easy;

public static class ToeplitzMatrix
{
    public static bool Run(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        Dictionary<int, int> dict = new();

        for (int i = 0; i < rows; i++)
        {
            int sr = i;
            int sc = 0;
            int num = matrix[sr][sc];

            while (sr < rows - 1 && sc < cols - 1)
            {
                sr++;
                sc++;

                if (num != matrix[sr][sc])
                    return false;

                //dict.Add(sr,sc);

                if (sr == rows - 1)
                {
                    sr = 0;
                    sc = sc - 1;
                    num = matrix[sr][sc];
                }
            }
        }
        return true;
    }
}


