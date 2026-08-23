namespace HashTable.Easy;

public static class SmallestMissingMultipleOfK
{
    //8,2,3,4,6 -> 2
    public static int Run(int[] nums, int k)
    {
        int[] visited = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % k == 0)
            {
                int index = (nums[i] / k) - 1;
                visited[index] = nums[i];
            }
        }

        for (int i = 0; i < visited.Length; i++)
        {
            if (visited[i] != k * (i + 1))
            {
                return k * (i + 1);
            }
        }

        return 0;
    }
}
