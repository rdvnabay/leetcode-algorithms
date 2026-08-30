using System.Numerics;

namespace HashTable.Easy;

public static class RemoveDigitFromNumberToMaximizeResult
{
    public static string Run(string number, char digit)
    {
        List<BigInteger> result = new();

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == digit)
            {
                var left = number.Substring(0, i);
                var right = number.Substring(i + 1);
                result.Add(BigInteger.Parse(left + right));
            }
        }

        return result.Max().ToString();
    }
}
