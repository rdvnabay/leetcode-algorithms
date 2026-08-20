/**
 * @id         1476
 * @title      Subrectangle Queries
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/subrectangle-queries/
 */
namespace Array.Medium;

public class SubrectangleQueries
{
    private int[][] _matrix;

    public SubrectangleQueries(int[][] rectangle)
    {
        _matrix = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
        {
            for (int j = col1; j <= col2; j++)
            {
                _matrix[i][j] = newValue;
            }
        }
    }

    public int GetValue(int row, int col)
    {
        return _matrix[row][col];
    }
}


