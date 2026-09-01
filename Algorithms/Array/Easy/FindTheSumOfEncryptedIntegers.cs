namespace Array.Easy;

public static class FindTheSumOfEncryptedIntegers
{
    public static int Run(int[] nums)
    {
        int total = 0;

        foreach (var num in nums)
        {
            int maxDigit = 0;
            int digitCount = 0;
            int currentNum = num;

            while (currentNum > 0)
            {
                int remainder = currentNum % 10;
                maxDigit = Math.Max(maxDigit, remainder);
                digitCount++;
                currentNum /= 10;
            }

            string value = string.Concat(Enumerable.Repeat(maxDigit, digitCount));
            total += int.Parse(value);
        }

        return total;
    }
}
