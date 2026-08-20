/**
 * @id         3783
 * @title      Mirror Distance of an Integer
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/mirror-distance-of-an-integer/
 */
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math.Easy;

public static class MirrorDistanceOfAnInteger
{
    public static int Run(int n)
    {
        StringBuilder sb = new();
        int originValue = n;

        while (n > 0)
        {
            int remainder = n % 10;
            sb.Append(remainder);
            n /= 10;
        }

        int reverseNumber = int.Parse(sb.ToString());

        return System.Math.Abs(originValue - reverseNumber);
    }
}


