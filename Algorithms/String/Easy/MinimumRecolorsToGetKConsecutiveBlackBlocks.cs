/**
 * @id         2379
 * @title      Minimum Recolors to Get K Consecutive Black Blocks
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/
 */
namespace String.Easy;

public static class MinimumRecolorsToGetKConsecutiveBlackBlocks
{
    public static int Run(string blocks, int k)
    {
        int start = 0;
        int end = k;
        int minValue = int.MaxValue;

        for (int i = k; i <= blocks.Length; i++)
        {
            int whiteTotal = 0;

            for (int j = start; j < end; j++)
            {
                if (blocks[j] == 'W')
                    whiteTotal++;
            }

            if (whiteTotal < minValue)
                minValue = whiteTotal;

            start++;
            end++;
        }

        return minValue;
    }
}
