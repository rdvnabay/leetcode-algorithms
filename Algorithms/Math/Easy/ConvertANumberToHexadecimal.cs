/**
 * @id         405
 * @title      Convert a Number to Hexadecimal
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/convert-a-number-to-hexadecimal/
 */
using System.Text;

namespace Algorithms.Math.Easy;

public static class ConvertANumberToHexadecimal
{
    //num negatif say� gelme durumu ele al�nacak!
    public static string Run(int num)
    {
        StringBuilder sb = new();
        Dictionary<int, char> dict = new() { { 10, 'a' }, { 11, 'b' }, { 12, 'c' }, { 13, 'd' }, { 14, 'e' }, { 15, 'f' } };

        while (num > 0)
        {
            int remainder = num % 16;
            num = num / 16;
            if (remainder > 9)
            {
                dict.TryGetValue(remainder, out char c);
                sb.Insert(0, c);
            }
            else
            {
                sb.Insert(0, remainder);
            }
        }
        return sb.ToString();

    }
}


