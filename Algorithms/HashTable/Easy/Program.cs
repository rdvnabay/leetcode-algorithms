
using HashTable.Easy;

namespace Algorithms.HashTable.Easy;

public static class HashTableEasyRunner
{
    public static void Run()
    {
        var hashMap = new DesignHashMap();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        hashMap.Put(2, 1);
        hashMap.Remove(2);

        DistributeCandies.Run(new int[] { 6, 6, 6, 6 });
        LongestHarmoniousSubsequence.Run(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 });
        FirstUniqueCharacterInAString.Run("loveleetcode");
        FindTheDifference.Run("aab", "aabb");
        LongestPalindrome.Run("ccc");
        VerifyingAnAlienDictionary.Run(new string[] { "hello","leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");
    }
}