namespace HashTable.Easy;

public static class PointsThatIntersectWithCars
{
    public static int Run(IList<IList<int>> nums)
    {
        HashSet<int> visited = new();

        for (int i = 0; i < nums.Count; i++)
        {
            int start = nums[i][0];
            int end = nums[i][1];

            for (int j = start; j <= end; j++)
                visited.Add(j);
        }

        return visited.Count;
    }
}
