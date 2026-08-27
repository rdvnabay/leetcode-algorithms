/**
 * @id         2545
 * @title      Sort the Students by Their Kth Score
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/sort-the-students-by-their-kth-score/
 */
namespace Array.Medium;

public static class SortTheStudentsByTheirKthScore
{
    public static int[][] Run(int[][] score, int k)
    {
        int rows = score.Length;
        int cols = score[0].Length;

        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++)
            result[i] = new int[cols];

        Dictionary<int, int> dict = new();

        for (int i = 0; i < rows; i++)
            dict[i] = score[i][k];

        var orderedIndexs = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();


        for (int i = 0; i < orderedIndexs.Count; i++)
        {
            for (int j = 0; j < cols; j++)
                result[i][j] = score[orderedIndexs[i]][j];
        }

        return result;
    }
}


