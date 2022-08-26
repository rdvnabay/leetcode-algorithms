using System.Numerics;
namespace Algorithms.Solutions.Easy;

public class PlusOne
{
    //Runtime: 181 ms, faster than 67.75 % of C# online submissions for Plus One.
    //Memory Usage: 41.4 MB, less than 16.88 % of C# online submissions for Plus One.
    public static int[] Run(int[] digits)
    {
        string numStr = "";

        foreach (var digit in digits)
            numStr += digit;

        BigInteger output = BigInteger.Parse(numStr) + 1;
       
        return Array.ConvertAll(output.ToString().ToArray(), x => (int)x - 48);
    }
}
