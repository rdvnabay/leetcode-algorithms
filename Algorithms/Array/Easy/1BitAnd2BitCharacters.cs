/**
 * @id         717
 * @title      1-bit and 2-bit Characters
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/1-bit-and-2-bit-characters/
 */
namespace Algorithms.Array.Easy;

public static class _1BitAnd2BitCharacters
{
    public static bool Run(int[] bits)
    {
        int i = 0;
        int result = bits[0];

        while (i < bits.Length - 2)
        {
            if (bits[i] == 1)
            {
                i += 2;
            }
            else
            {
                i++;
            }
            result = bits[i];
        }
        return result == 0;
    }
}


