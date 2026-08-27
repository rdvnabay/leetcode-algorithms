using System.Text;

namespace Array.Medium;

public static class FindUniqueBinaryString
{
    //"111","011","001"
    public static string Run(string[] nums)
    {
        int n = nums[0].Length;
        int length = (int)Math.Pow(2, n);
        int[] arr = new int[length];

        foreach (var num in nums)
        {
            int digit = 0;
            int m = nums[0].Length;

            for (int i = 0; i < num.Length; i++)
            {
                digit += (num[i] - '0') * ((int)Math.Pow(2, m - 1));
                m--;
            }
            arr[digit] = digit;
        }

        int findValue = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i)
            {
                findValue = i;
                break;
            }
        }

        return Convert.ToString(findValue, 2).PadLeft(n, '0');
    }
}
