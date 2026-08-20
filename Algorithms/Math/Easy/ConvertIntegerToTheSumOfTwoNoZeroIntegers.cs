namespace Math.Easy;

public static class ConvertIntegerToTheSumOfTwoNoZeroIntegers
{
    //505 1 504
    public static int[] Run(int n)
    {
        int a = 1;
        int b = n - a;

        int tempA = a;
        int tempB = b;

        while (tempA > 0)
        {
            if (a % 10 == 0 || b % 10 == 0)
            {
                a += 1;
                b -= 1;
            }
            else
            {
                break;
            }
        }

        return new int[] { a, b };
    }
}
