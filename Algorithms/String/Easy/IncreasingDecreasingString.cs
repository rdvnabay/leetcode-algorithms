/**
 * @id         1370
 * @title      Increasing Decreasing String
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/increasing-decreasing-string/
 */
namespace String.Easy;

public static class IncreasingDecreasingString
{
    //aaaabbbbcccc

    //abccbaabccba
    public static string Run(string s)
    {
        HashSet<char> set = new(s); // 'a' 'b' 'c'
        //System.Array.Sort(set.ToArray());
        var test= set.Order();
        bool isAscending = true;
        
        return "";
    }
}


