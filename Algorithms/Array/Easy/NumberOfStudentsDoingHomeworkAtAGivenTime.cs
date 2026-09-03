namespace Array.Easy;

public static class NumberOfStudentsDoingHomeworkAtAGivenTime
{
    public static int Run(int[] startTime, int[] endTime, int queryTime)
    {
        int counter = 0;

        for (int i = 0; i < startTime.Length; i++)
        {
            if ((startTime[i] <= queryTime) && (endTime[i] >= queryTime))
                counter++;
        }

        return counter;
    }
}
