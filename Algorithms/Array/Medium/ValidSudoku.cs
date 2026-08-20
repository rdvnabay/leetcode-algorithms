/**
 * @id         36
 * @title      Valid Sudoku
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/valid-sudoku/
 */
namespace Algorithms.Array.Medium;

public static class ValidSudoku
{
    public static bool Run(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        if (!IsValidRows(board, rows, cols))
            return false;

        if (!IsValidColumns(board, rows, cols))
            return false;

        IsValid3x3(board, rows, cols, 0, 0);

        return false;
    }

    static bool IsValidRows(char[][] board, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            int[] nums = new int[rows];

            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == '.')
                    continue;

                int num = board[i][j] - '0';
                if (nums[num - 1] == 0)
                    nums[num - 1] = num;
                else
                    return false;

            }
            System.Array.Clear(nums);
        }

        return true;
    }

    static bool IsValidColumns(char[][] board, int rows, int cols)
    {
        for (int i = 0; i < cols; i++)
        {
            int[] nums = new int[cols];

            for (int j = 0; j < rows; j++)
            {
                if (board[j][i] == '.')
                    continue;

                int num = board[j][i] - '0';
                if (nums[num - 1] == 0)
                    nums[num - 1] = num;
                else
                    return false;
            }
            System.Array.Clear(nums);
        }

        return true;
    }

    //missing code
    static bool IsValid3x3(char[][] board, int row, int col, int i, int j)
    {
        return false;
    }
}


