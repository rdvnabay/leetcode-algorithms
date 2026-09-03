/**
 * @id         1436
 * @title      Destination City
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/destination-city/
 */
namespace Array.Easy;

public static class DestinationCity
{
    public static string Run(IList<IList<string>> paths)
    {
        HashSet<string> sourceCities = new();

        foreach (var path in paths)
        {
            string src = path[0];
            sourceCities.Add(src);
        }

        foreach (var path in paths)
        {
            string dest = path[1];
            if (!sourceCities.Contains(dest))
                return dest;
        }

        return string.Empty;
    }
}
