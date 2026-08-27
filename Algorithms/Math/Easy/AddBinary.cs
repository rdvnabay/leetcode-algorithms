/**
 * @id         67
 * @title      Add Binary
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/add-binary/
 */
using System.Text;

namespace Algorithms.Math.Easy;

public static class AddBinary
{
    public static string Run(string a, string b)
    {
        int maxLength = System.Math.Max(a.Length, b.Length);

        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');

        int carry = 0;
        StringBuilder sb = new();

        for (int i = maxLength - 1; i >= 0; i--)
        {
            var result = System.Math.Abs(a[i] - b[i]);

            if (result == 0)
            {
                if (a[i] == '1' || b[i] == '1')
                {
                    sb.Append((result + carry) % 2);
                    carry = 1;
                }
                else
                {
                    sb.Append((result + carry) % 2);
                    carry = 0;
                }
            }
            else
            {
                sb.Append((result + carry) % 2);
            }
        }

        if (carry == 1)
            sb.Append(carry);

        return new string(sb.ToString().Reverse().ToArray());
    }
}


