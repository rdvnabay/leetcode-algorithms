using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math.Easy;

public static class MirrorDistanceOfAnInteger
{
    public static int Run(int n)
    {
        StringBuilder sb = new();
        int originValue = n;

        while (n > 0)
        {
            int remainder = n % 10;
            sb.Append(remainder);
            n /= 10;
        }

        int reverseNumber = int.Parse(sb.ToString());

        return System.Math.Abs(originValue - reverseNumber);
    }
}
