/**
 * @id         1337
 * @title      The K Weakest Rows in a Matrix
 * @topic      sorting
 * @difficulty Easy
 * @link       https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
 */
namespace Algorithms.Sorting.Easy;

public static class TheKWeakestRowsInAMatrix
{
    public static int[] Run(int[][] mat, int k)
    {
        int rows = mat.Length;
        int cols = mat[0].Length;
        Dictionary<int, int> dict = new();

        for (int i = 0; i < rows; i++)
        {
            int counter = 0;
            for (int j = 0; j < cols; j++)
            {
                if (mat[i][j] == 1)
                    counter++;
                else
                    break;
            }
            dict.Add(i, counter);
        }


        return dict.OrderBy(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}


