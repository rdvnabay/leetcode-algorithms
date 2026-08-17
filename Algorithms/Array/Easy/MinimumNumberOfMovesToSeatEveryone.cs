namespace Array.Easy;

public static class MinimumNumberOfMovesToSeatEveryone
{
    public static int Run(int[] seats, int[] students)
    {
        int total = 0;
        System.Array.Sort(seats);
        System.Array.Sort(students);

        for (int i = 0; i < students.Length; i++)
            total += Math.Abs(students[i] - seats[i]);

        return total;
    }
}
