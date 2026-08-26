namespace String.Easy;

public static class FindTheKBeautyOfANumber
{
    public static int Run(int num, int k)
    {
        string numStr = num.ToString();
        int counter = 0;

        for (int i = 0; i <= numStr.Length - k; i++)
        {
            int value = int.Parse(numStr.Substring(i, k));

            if (value != 0 && num % value == 0)
                counter++;
        }

        return counter;
    }
}
