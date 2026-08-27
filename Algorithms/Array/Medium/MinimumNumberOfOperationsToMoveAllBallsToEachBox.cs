/**
 * @id         1769
 * @title      Minimum Number of Operations to Move All Balls to Each Box
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
 */
namespace Array.Medium;

public static class MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    public static int[] Run(string boxes)
    {
        int[] result = new int[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            int total = 0;

            for (int j = 0; j < boxes.Length; j++)
            {
                if (boxes[j] == '1')
                    total += Math.Abs(i - j);
            }

            result[i] = total;
        }

        return result;
    }
}


