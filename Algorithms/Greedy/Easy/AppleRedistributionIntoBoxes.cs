namespace Greedy.Easy;

public static class AppleRedistributionIntoBoxes
{
    //Input: apple = [1, 3, 2], capacity = [4, 3, 1, 5, 2]
    //Output: 2
    public static int Run(int[] apple, int[] capacity)
    {
        int totalCapacity = 0;
        int totalAppleCount = 0;

        for (int i = 0; i < apple.Length; i++)
            totalAppleCount += apple[i];

        Array.Sort(capacity, (a, b) => b.CompareTo(a));

        int index = 0;
        while (totalCapacity < totalAppleCount)
        {
            totalCapacity += capacity[index];
            index++;
        }

        return index;
    }
}
