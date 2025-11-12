namespace Algorithms.Solutions.Medium;

public static class ReverseInteger
{
    public static int Run(int x)
    {
        string strNum = x.ToString();
        string result = string.Empty;

        if (strNum[0] == '-')
            result += strNum[0];

        for (int i = strNum.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(strNum[i]))
                result += strNum[i];
        }

        long value = Convert.ToInt64(result);

        if (value < int.MinValue || value > int.MaxValue)
            return 0;

        return int.Parse(result);
    }
}
