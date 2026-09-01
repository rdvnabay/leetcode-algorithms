namespace Array.Easy;

public static class AntOnTheBoundary
{
    public static int Run(int[] nums)
    {
        int distance = 0;
        int counter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            distance += nums[i];
            if (distance == 0)
                counter++;
        }

        return counter;
    }
}
