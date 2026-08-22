using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HashTable.Easy;

public static class Finding3DigitEvenNumbers
{
    public static int[] Run(int[] digits)
    {
        Array.Sort(digits);
        HashSet<int> result = new HashSet<int>();

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                continue;

            for (int j = 0; j < digits.Length; j++)
            {
                if (i == j)
                    continue;

                for (int k = 0; k < digits.Length; k++)
                {
                    if (j == k || i == k)
                        continue;

                    if (digits[k] % 2 != 0)
                        continue;

                    int number = digits[i] * 100 + digits[j] * 10 + digits[k];
                    result.Add(number);
                }
            }
        }

        return result.ToArray();
    }


    //Alternative solutions
    public static int[] Solution2(int[] digits)
    {
        List<char[]> chars = new List<char[]>();
        Array.Sort(digits);

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                continue;

            for (int j = 0; j < digits.Length; j++)
            {
                if (i == j)
                    continue;

                for (int k = 0; k < digits.Length; k++)
                {
                    if (j == k || i == k)
                        continue;

                    if (digits[k] % 2 != 0)
                        continue;

                    chars.Add(new char[]
                    {
                        (char)(digits[i] + '0'),
                        (char)(digits[j] + '0'),
                        (char)(digits[k] + '0')
                    });
                }
            }
        }

        HashSet<int> result = new HashSet<int>();

        foreach (var item in chars)
            result.Add(int.Parse(new string(item)));

        return result.ToArray();
    }
}
