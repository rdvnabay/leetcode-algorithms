/**
 * @id         504
 * @title      Base 7
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/base-7/
 */
using System.Text;

namespace Algorithms.Math.Easy;

public static class Base7
{
    public static string Run(int num)
    {
        const int BaseValue = 7;
        bool numIsNegative = num < 0;
        num = System.Math.Abs(num);

        StringBuilder sb = new();

        while (num >= BaseValue)
        {
            int remainder = num % BaseValue;
            sb.Insert(0, remainder);
            num = num / BaseValue;
        }

        sb.Insert(0, num);

        if (numIsNegative)
            sb.Insert(0, "-");

        return sb.ToString();
    }
}


