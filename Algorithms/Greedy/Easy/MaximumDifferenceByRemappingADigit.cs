/**
 * @id         2566
 * @title      Maximum Difference by Remapping a Digit
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-difference-by-remapping-a-digit/
 */
namespace Greedy.Easy;

public static class MaximumDifferenceByRemappingADigit
{
    public static int Run(int num)
    {
        string numStr = num.ToString();
        char[] max = new char[numStr.Length];
        char[] min = new char[numStr.Length];

        char minDigit = FindMinDigit(num);
        char maxDigit = FindMaxDigit(num);

        for (int i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] == maxDigit)
                min[i] = '0';
            else
                min[i] = numStr[i];
        }

        for (int i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] == minDigit)
                max[i] = '9';
            else
                max[i] = numStr[i];
        }

        int maxResult = int.Parse(new string(max));
        int minResult = int.Parse(new string(min));

        return maxResult - minResult;
    }

    static char FindMinDigit(int num)
    {
        int min = int.MaxValue;

        while (num > 0)
        {
            int remainder = num % 10;
            min = Math.Min(min, remainder);
            num /= 10;
        }

        return (char)(min + '0');
    }

    static char FindMaxDigit(int num)
    {
        int max = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            max = Math.Max(max, remainder);
            num /= 10;
        }

        return (char)(max + '0');
    }
}
