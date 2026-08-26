namespace String.Medium;

public static class GenerateBinaryStringsWithoutAdjacentZeros
{
    public static IList<string> Run(int n)
    {
        int length = (int)Math.Pow(2, n);
        List<string> values = new();

        for (int i = 0; i < length; i++)
        {
            string value = Convert.ToString(i, 2).PadLeft(n, '0');
            bool isValid = true;

            for (int j = 0; j < value.Length - 1; j++)
            {
                if (value[j] == '0' && value[j + 1] == '0')
                {
                    isValid = false;   
                    break;
                }
            }

            if (isValid)
                values.Add(value);
        }

        return values;
    }
}
