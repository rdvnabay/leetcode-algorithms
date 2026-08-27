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
        char[] chars = new char[num.ToString().Length];

        int index = chars.Length - 1;
        int minValue = int.MaxValue;

        while (num > 0)
        {
            int remainder = num % 10;
            if (remainder < minValue)
                minValue = remainder;


            chars[index] = (char)('0' + remainder);
            num /= 10;
            index--;
        }

        char[] max = new char[chars.Length];
        char[] min = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            char minValueChar = (char)('0' + minValue);

            if (chars[i] == minValueChar)
            {
                max[i] = '9';
                min[i] = '0';
            }
            else
            {
                max[i] = chars[i];
                min[i] = chars[i];
            }
        }

        int maxResult = int.Parse(new string(max));
        int minResult = int.Parse(new string(min));

        return maxResult - minResult;
    }

    public static int Run2(int num)
    {
        string numStr = num.ToString();
        char firstDigit = numStr[0] ;
        char[] max = new char[numStr.Length];
        char[] min = new char[numStr.Length];

        for (int i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] == firstDigit)
            {
                min[i] = '0';
                max[i] = '9';
            }
            else
            {
                min[i] = numStr[i];
                max[i] = numStr[i];
            }
        }
        return 0;
    }
}
