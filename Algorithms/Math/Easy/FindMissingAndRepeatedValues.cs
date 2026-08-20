/**
 * @id         2965
 * @title      Find Missing and Repeated Values
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-missing-and-repeated-values/
 */
namespace Math.Easy;

public static class FindMissingAndRepeatedValues
{
    public static int[] Run(int[][] grid)
    {
        int n = grid.Length * grid.Length;
        int[] numbers = new int[n];
        int repeatedNumber = 0;
        int totalNumber = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                int num = grid[i][j];
                totalNumber += num;

                if (numbers[num - 1] == 0)
                    numbers[num - 1] = num;
                else
                    repeatedNumber = num;
            }
        }

        int missingNumber = (n * (n + 1) / 2) - totalNumber + repeatedNumber;

        return new int[2]
        {
            repeatedNumber,
            missingNumber
        };
    }
}


