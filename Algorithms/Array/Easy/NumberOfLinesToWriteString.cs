/**
 * @id         806
 * @title      Number of Lines To Write String
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-lines-to-write-string/
 */
namespace Algorithms.Array.Easy;

public static class NumberOfLinesToWriteString
{
    public static int[] Run(int[] widths, string s)
    {
        int row = 1;
        int total = 0;
        int[] result = new int[2];

        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            int width = widths[index];

            total += width;

            if (total > 100)
            {
                total = width;
                row++;
            }
        }

        result[0] = row;
        result[1] = total;

        return result;
    }
}


