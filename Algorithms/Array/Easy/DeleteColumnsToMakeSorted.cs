/**
 * @id         944
 * @title      Delete Columns to Make Sorted
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/delete-columns-to-make-sorted/
 */
namespace Algorithms.Array.Easy;

public static class DeleteColumnsToMakeSorted
{
    public static int Run(string[] strs)
    {
        int rows = strs.Length;
        int cols = strs[0].Length;
        int result = 0;

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows - 1; j++)
            {
                if (strs[j][i] > strs[j + 1][i])
                {
                    result++;
                    break;
                }
            }
        }
        return result;
    }
}


