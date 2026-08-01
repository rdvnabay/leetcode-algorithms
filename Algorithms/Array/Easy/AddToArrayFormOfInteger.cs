using System.Numerics;
using System.Text;

namespace Algorithms.Array.Easy;

public static class AddToArrayFormOfInteger
{
    public static IList<int> Run(int[] num, int k)
    {
        StringBuilder sb = new();
        List<int> result = new List<int>();

        for (int i = 0; i < num.Length; i++)
            sb.Append(num[i]);

        BigInteger number = BigInteger.Parse(sb.ToString());
        number = number + k;

        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length; i++)
            result.Add(int.Parse(numberString[i].ToString()));

        return result;
    }
}
