namespace Algorithms.String.Easy;

public static class GreatestCommonDivisorOfStrings
{
    public static string Run(string str1, string str2)
    {
        int i = 0;
        int matchCount = 0;

        while (i < str1.Length && i < str2.Length)
        {
            if (str1[i] == str2[i])
                matchCount++;
            else
                break;

            i++;
        }

        if (i == 0)
            return "";

        int max = System.Math.Max(str1.Length, str2.Length);
        int min = System.Math.Min(str1.Length, str2.Length);

        var divisors = GetDivisors(max);

        foreach (var divisor in divisors)
        {
            if (max % divisor == 0 && min % divisor == 0)
            {
                if (str1.Length <= str2.Length)
                {
                    if (str1.Substring(0, divisor) == str2[^divisor..])
                        return str1.Substring(0, divisor);
                }

                if (str2.Substring(0, divisor) == str1[^divisor..])
                    return str2.Substring(0, divisor);
            }
        }

        return "";
    }

    static List<int> GetDivisors(int number)
    {
        List<int> result = new List<int>();

        for (int i = number / 2; i >= 1; i--)
        {
            if (number % i == 0)
                result.Add(i);
        }

        return result;
    }
}
