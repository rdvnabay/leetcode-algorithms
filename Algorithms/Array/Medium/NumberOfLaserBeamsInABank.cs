/**
 * @id         2125
 * @title      Number of Laser Beams in a Bank
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
 */
namespace Array.Medium;

public static class NumberOfLaserBeamsInABank
{
    public static int Run(string[] bank)
    {
        int prev = 0;
        int next = 0;
        int result = 0;

        foreach (var item in bank)
        {
            int totalDevices = 0;

            foreach (var num in item)
            {
                if (num == '1')
                    totalDevices++;
            }

            if (totalDevices > 0)
            {
                if (prev == 0)
                {
                    prev = totalDevices;
                }
                else
                {
                    if (next == 0)
                    {
                        next = totalDevices;
                        result += prev * next;
                        prev = next;
                        next = 0;
                    }
                }
            }
        }

        return result;
    }
}

