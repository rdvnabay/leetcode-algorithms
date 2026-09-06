namespace Array.Easy;

public static class MinimumCapacityBox
{
    public static int Run(int[] capacity, int itemSize)
    {
        int result = -1;
        int diff = int.MaxValue;

        for (int i = 0; i < capacity.Length; i++)
        {
            int currentCapacity = capacity[i];
            if (currentCapacity >= itemSize)
            {
                if (currentCapacity - itemSize < diff)
                {
                    diff = currentCapacity - itemSize;
                    result = i;
                }
            }
        }

        return result;
    }
}
