using System.Text;

namespace Math.Easy;

public static class ConvertANumberToHexadecimal
{
    //num negatif sayı gelme durumu ele alınacak!
    public static string Run(int num)
    {
        StringBuilder sb = new();
        Dictionary<int, char> dict = new() { { 10, 'a' }, { 11, 'b' }, { 12, 'c' }, { 13, 'd' }, { 14, 'e' }, { 15, 'f' } };

        while (num > 0)
        {
            int remainder = num % 16;
            num = num / 16;
            if (remainder > 9)
            {
                dict.TryGetValue(remainder, out char c);
                sb.Insert(0, c);
            }
            else
            {
                sb.Insert(0, remainder);
            }
        }
        return sb.ToString();

    }
}
