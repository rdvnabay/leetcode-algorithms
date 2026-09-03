/**
 * @id         1637
 * @title      Widest Vertical Area Between Two Points Containing No Points
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
 */
namespace Array.Easy;

public static class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public static int Run(int[][] points)
    {
        int[] values = new int[points.Length];

        for (int i = 0; i < points.Length; i++)
            values[i] = points[i][0];

        System.Array.Sort(values);

        int maxValue = int.MinValue;
        for (int i = 0; i < values.Length - 1; i++)
        {
            int width = values[i + 1] - values[i];
            if (width > maxValue)
                maxValue = width;
        }

        return maxValue;
    }


    //Alternative solutions
    static int Solution2(int[][] points)
    {
        int[] values = points.Select(point => point[0]).ToArray();
        System.Array.Sort(values);

        int maxWidth = 0;

        for (int i = 1; i < values.Length; i++)
            maxWidth = Math.Max(maxWidth, values[i] - values[i - 1]);

        return maxWidth;
    }
}
