namespace Algorithms.Solutions.Easy;

public static class NumberOf1Bits
{
    public static int Run(int n)
    {
        List<int> bits = new();
        do
        {
            bits.Add(n % 2);
            n = n / 2;
        }
        while (n >= 2);
        bits.Add(n);
        int countOfOnes = bits.Where(x => x == 1).Count();
        return countOfOnes;
    }
}
