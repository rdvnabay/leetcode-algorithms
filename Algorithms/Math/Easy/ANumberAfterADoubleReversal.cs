namespace Math.Easy;

public static class ANumberAfterADoubleReversal
{
    public static bool Run(int num)
    {
        if (num == 0)
            return true;

        if (num % 10 != 0)
            return true;

        return false;
    }
}
