using System.Text;

namespace Math.Easy;

public static class FindTheKeyOfTheNumbers
{
    public static int Run(int num1, int num2, int num3)
    {
        string num1Str = num1.ToString().PadLeft(4, '0');
        string num2Str = num2.ToString().PadLeft(4, '0');
        string num3Str = num3.ToString().PadLeft(4, '0');

        StringBuilder sb = new();

        for (int i = 0; i < 4; i++)
        {
            int num1Value = num1Str[i] - '0';
            int num2Value = num2Str[i] - '0';
            int num3Value = num3Str[i] - '0';

            int min = System.Math.Min(System.Math.Min(num1Value, num2Value), num3Value);
            sb.Append(min);
        }

        return int.Parse(sb.ToString());
    }
}
