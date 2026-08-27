/**
 * @id         3483
 * @title      Unique 3-Digit Even Numbers
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/unique-3-digit-even-numbers/
 */
namespace Array.Easy;

public static class Unique3DigitEvenNumbers
{
    public static int Run(int[] digits)
    {
        HashSet<string> uniqueOddNumbers = new();

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
                    if (digits[k] % 2 == 1)
                        continue;

                    if (i != k && j != k)
                        uniqueOddNumbers.Add($"{digits[i]}{digits[j]}{digits[k]}");
                }
            }
        }

        return uniqueOddNumbers.Count;
    }
}
