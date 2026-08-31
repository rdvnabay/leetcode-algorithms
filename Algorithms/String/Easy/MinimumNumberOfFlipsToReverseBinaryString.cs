using System.Text;

namespace String.Easy;

public static class MinimumNumberOfFlipsToReverseBinaryString
{
    public static int Run(int n)
    {
        int count = 0;
        StringBuilder sb = new();

        while (n > 0)
        {
            int remainder = n % 2;
            sb.Append(remainder);
            n /= 2;
        }

        string reverseBinary = sb.ToString();

        for (int i = 0; i < reverseBinary.Length; i++)
        {
            if (reverseBinary[i] != reverseBinary[^(i + 1)])
                count++;
        }

        return count;
    }
}
