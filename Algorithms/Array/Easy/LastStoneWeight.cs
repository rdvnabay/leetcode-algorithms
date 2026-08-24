namespace Array.Easy;

public static class LastStoneWeight
{
    public static int Run(int[] stones)
    {
        while (stones.Length > 1)
        {
            System.Array.Sort(stones);

            int heaviest = stones[^1];
            int secondHeaviest = stones[^2];

            if (heaviest == secondHeaviest)
            {
                stones = stones[..^2];
            }
            else
            {
                stones = stones[..^1];
                stones[stones.Length - 1] = heaviest - secondHeaviest;
            }
        }

        return stones.Length == 0 ? 0 : stones[0];
    }
}
