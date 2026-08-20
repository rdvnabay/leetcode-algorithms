/**
 * @id         319
 * @title      Bulb Switcher
 * @topic      math
 * @difficulty Medium
 * @link       https://leetcode.com/problems/bulb-switcher/
 */
namespace Math.Medium;

public static class BulbSwitcher
{
    public static int Run(int n)
    {
        bool[] bulbs = new bool[n];

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j += i)
            {
                if (j % i == 0)
                    bulbs[j - 1] = !bulbs[j - 1];
            }
        }

        int counter = 0;

        for (int i = 0; i < bulbs.Length; i++)
        {
            if (bulbs[i] == true)
                counter++;
        }

        return counter;
    }
}


