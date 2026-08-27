/**
 * @id         1323
 * @title      Maximum 69 Number
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-69-number/
 */
using System.Text;

namespace Algorithms.Math.Easy;

public static class Maximum69Number
{
    public static int Run(int num)
    {
        char[] chars = num.ToString().ToCharArray();

        int index = Array.IndexOf(chars, '6');

        if (index != -1)
            chars[index] = '9';

        return int.Parse(new string(chars));
    }
}


