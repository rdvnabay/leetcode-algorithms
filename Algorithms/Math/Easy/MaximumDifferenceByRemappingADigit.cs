/**
 * @id         2566
 * @title      Maximum Difference by Remapping a Digit
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-difference-by-remapping-a-digit/
 */
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Math.Easy;

public static class MaximumDifferenceByRemappingADigit
{
    //11891
    public static int Run(int num)
    {
        int maxValue = GetMaxValue(num);
        int minValue = GetMinValue(num);

        return maxValue - minValue;
    }

    static int GetMaxValue(int num)
    {
        string numStr = num.ToString();
        int current = numStr[0] - '0';
        double maxValue = 0;

        for (int i = 0; i < numStr.Length; i++)
        {
            int value = numStr[i] - '0';

            if (value < 9 && current == value)
                value = 9;
            else
            {
                if (numStr.Length - 1 > i)
                    current = numStr[i + 1] - '0';
            }

            maxValue += System.Math.Pow(10, numStr.Length - 1 - i) * value;
        }

        return (int)maxValue;
    }

    //current de�eri i�in mant�ksal hata giderilecek!
    static int GetMinValue(int num)
    {
        string numStr = num.ToString();
        int current = numStr[0] - '0';
        double minValue = 0;

        for (int i = 0; i < numStr.Length; i++)
        {
            int value = numStr[i] - '0';

            if (value > 0 && current == value)
                value = 0;
            else
            {
                if (numStr.Length - 1 > i)
                    current = numStr[i + 1] - '0';
            }

            minValue += System.Math.Pow(10, numStr.Length - 1 - i) * value;
        }

        return (int)minValue;
    }
}


