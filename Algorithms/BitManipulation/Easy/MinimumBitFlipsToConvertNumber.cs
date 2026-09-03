/**
 * @id         2220
 * @title      Minimum Bit Flips to Convert Number
 * @topic      BitManipulation
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-bit-flips-to-convert-number/
 */
namespace BitManipulation.Easy;

public static class MinimumBitFlipsToConvertNumber
{
    public static int Run(int start, int goal)
    {
        int maxNumber = Math.Max(start, goal);
        int length = Convert.ToString(maxNumber, 2).Length;

        string startBinary = Convert.ToString(start, 2).PadLeft(length, '0');
        string goalBinary = Convert.ToString(goal, 2).PadLeft(length, '0');
      
        int counter = 0;
 
        for (int i = 0; i < length; i++)
        {
            if (startBinary[i] != goalBinary[i])
                counter++;
        }

        return counter;
    }
}
