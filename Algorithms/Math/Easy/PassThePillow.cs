namespace Math.Easy;

public static class PassThePillow
{
    //4 5
    public static int Run(int n, int time)
    {
        for (int i = 1; i <= n;)
        {
            if (i == 1)
                i++;

            else if (i == n)
                i--;

            time--;

            if (time == 0)
                return i;
        }

        return -1;
    }
}
