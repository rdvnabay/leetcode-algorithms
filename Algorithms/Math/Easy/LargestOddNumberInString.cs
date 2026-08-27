/**
 * @id         1903
 * @title      Largest Odd Number in String
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/largest-odd-number-in-string/
 */
namespace Math.Easy;

public static class LargestOddNumberInString
{
    public static string Run(string num)
    {
        int left = 0;
        int right = num.Length - 1;
        bool isLeftFounded = false;
        bool isRightFounded = false;

        if (left == right)
            return (int)num[0] % 2 == 1 ? num[0].ToString() : "";

        while (left <= right)
        {
            if (num[left] % 2 == 1)
            {
                isLeftFounded = true;

                if (isRightFounded)
                    break;
            }
            else
                left++;

            if (num[right] % 2 == 1)
            {
                isRightFounded = true;

                if (isLeftFounded)
                    break;
            }
            else
                right--;
        }

        int index = left;
        char[] resultChar = new char[right - left + 1];

        for (int i = 0; i < resultChar.Length; i++)
        {
            resultChar[i] = num[index];
            index++;
        }

        return new string(resultChar);
    }
}


