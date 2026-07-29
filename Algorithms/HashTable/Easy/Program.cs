using Algorithms.HashTable.Easy.Solutions;

namespace Algorithms.HashTable.Easy;

public static class HashTableEasyRunner
{
    public static void Run()
    {
        // 575: Distribute Candies
        DistributeCandies.Run(new int[] { 6, 6, 6, 6 });
        // 594: Longest Harmonious Subsequence
        LongestHarmoniousSubsequence.Run(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 });
        // 706: Design HashMap
        var hashMap = new DesignHashMap();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Console.WriteLine(hashMap.Get(1));  // 1
        Console.WriteLine(hashMap.Get(3));  // -1 (not found)
        hashMap.Put(2, 1);
        Console.WriteLine(hashMap.Get(2));  // 1
        hashMap.Remove(2);
        Console.WriteLine(hashMap.Get(2));  // -1
    }
}