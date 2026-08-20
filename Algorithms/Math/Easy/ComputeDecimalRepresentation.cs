namespace Math.Easy;

public static class ComputeDecimalRepresentation
{
    public static int[] Run(int n)
    {
        List<int> result = new();
        string numStr = n.ToString();
        int pow = numStr.Length - 1;

        foreach (var num in numStr)
        {
            int value = num - '0';

            if (value != 0)
                result.Add((int)System.Math.Pow(10, pow) * value);
            
            pow--;
        }

        return result.ToArray();
    }
}
