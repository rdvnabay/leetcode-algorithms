/**
 * @id         3446
 * @title      Sort Matrix by Diagonals
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/sort-matrix-by-diagonals/
 */
namespace Array.Medium;

public static class SortMatrixByDiagonals
{
    //[1,7,3],[9,8,2],[4,5,6]

    //[8,2,3],[9,6,7],[4,5,1]
    public static int[][] Run(int[][] grid)
    {
        int row = grid.Length - 2;
        int col = 0;

        while (row < grid.Length)
        {
            row++;
            col++;

            if (row >= col)
            {
                //büyükten küçüğe sırala
            }
            else
            {
                //küçükten büyüğe sırala
            }
        }
        return null;
    }
}


