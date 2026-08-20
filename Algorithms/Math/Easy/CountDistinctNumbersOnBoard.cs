namespace Math.Easy;

public static class CountDistinctNumbersOnBoard
{
    public static int Run(int n)
    {
        HashSet<int> numbers = new() { n };
        Queue<int> queue = new();

        queue.Enqueue(n);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            for (int i = 1; i < current; i++)
            {
                if (current % i == 1 && numbers.Add(i))
                {
                    queue.Enqueue(i);
                }
            }
        }

        return numbers.Count;
    }

    //Alternative solutions
    static int Solution2(int n)
    {
        return n == 1 ? 1 : n - 1;
    }
}
