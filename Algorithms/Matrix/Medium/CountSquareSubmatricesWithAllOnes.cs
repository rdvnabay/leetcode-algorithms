/**
 * @id         1277
 * @title      Count Square Submatrices with All Ones
 * @topic      Matrix
 * @difficulty Medium
 * @link       https://leetcode.com/problems/count-square-submatrices-with-all-ones/
 */
namespace Matrix.Medium;

public static class CountSquareSubmatricesWithAllOnes
{
    //[0,1,1,1],
    //[1,1,1,1],
    //[0,1,1,1]
    public static int Run(int[][] matrix)
    {
        //3x4
        //1x1 2x2 3x3 
        int total = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                //1x1
                if (matrix[i][j] == 1)
                    total++;
            }
        }
        return 0;
    }
}
