/**
 * @id         3726
 * @title      Remove Zeros in Decimal Representation
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/remove-zeros-in-decimal-representation/
 */
using System.Text;

namespace Math.Easy;

public static class RemoveZerosInDecimalRepresentation
{
    public static long Run(long n)
    {
        StringBuilder sb = new();
        string numStr = n.ToString();

        foreach (var num in numStr)
        {
            if (num != '0')
                sb.Append(num);
        }

        return long.Parse(sb.ToString());
    }


    //Alternative solutions
    static long Solution2(long n)
    {
        StringBuilder sb = new();

        while (n > 0)
        {
            long remainder = n % 10;
            if (remainder != 0)
            {
                sb.Append(remainder);
            }
            n /= 10;
        }

        return long.Parse(new string(sb.ToString().Reverse().ToArray()));
    }
}


