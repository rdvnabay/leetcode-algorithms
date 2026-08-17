namespace Array.Easy;

public static class NumberOfEmployeesWhoMetTheTarget
{
    public static int Run(int[] hours, int target)
    {
        int result = 0;

        foreach (var hour in hours)
        {
            if (hour >= target)
                result++;
        }

        return result;
    }
}
