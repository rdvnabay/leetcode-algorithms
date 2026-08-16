using System.Net.Http.Headers;

namespace String.Easy;

public static class Largest3SameDigitNumberInString
{
    public static string Run(string num)
    {
        int maxValue = -1;

        for (int i = 0; i < num.Length - 2;)
        {
            var left = num[i];
            var mid = num[i + 1];
            var right = num[i + 2];

            if (left == mid && mid == right)
            {
                int value = left - '0';
                if (value > maxValue)
                    maxValue = value;

                i += 3;
            }
            else
            {
                i++;
            }
        }

        if (maxValue == -1)
            return "";

        return new string(maxValue.ToString()[0], 3);
    }
}
