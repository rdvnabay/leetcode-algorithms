namespace Array.Easy;

public static class DefuseTheBomb
{
    public static int[] Run(int[] code, int k)
    {
        int[] result = new int[code.Length];

        if (k == 0)
            return result;

        bool isPositive = k > 0;

        for (int i = 0; i < code.Length; i++)
        {
            int j = i;
            int total = 0;
            int step = Math.Abs(k);

            while (step > 0)
            {
                if (isPositive)
                {
                    if (j == code.Length - 1)
                        j = 0;
                    else
                        j++;
                }
                else
                {
                    if (j == 0)
                        j = code.Length - 1;
                    else
                        j--;
                }

                step--;
                total += code[j];
            }

            result[i] = total;
        }

        return result;
    }
}
