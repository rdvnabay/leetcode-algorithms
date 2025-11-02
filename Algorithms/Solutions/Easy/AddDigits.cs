namespace Algorithms.Solutions.Easy;

public static class AddDigits
{
    public static int Run(int num)
    {
        do
        {
            num = SetNumber(num);
        }
        while (num >= 10);

        return num;
    }

    public static int SetNumber(int num)
    {
        List<int> digits = new();

        while (num > 0)
        {
            digits.Add(num % 10);
            num = num / 10;
        }


        digits.Reverse();
        var result = digits.Select(x => x).Sum();
        return result;
    }
}
