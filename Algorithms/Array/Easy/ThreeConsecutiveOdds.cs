namespace Array.Easy;

public static class ThreeConsecutiveOdds
{
    public static bool Run(int[] arr)
    {
        int oddCount = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 1)
                oddCount++;
            else
                oddCount = 0;

            if (oddCount == 3)
                return true;
        }

        return false;
    }
}
