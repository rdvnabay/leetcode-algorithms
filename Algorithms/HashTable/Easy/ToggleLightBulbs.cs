/**
 * @id         3842
 * @title      Toggle Light Bulbs
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/toggle-light-bulbs/
 */
namespace HashTable.Easy;

public static class ToggleLightBulbs
{
    public static IList<int> Run(IList<int> bulbs)
    {
        List<int> result = new();
        Dictionary<int, int> dict = new();

        foreach (var bulb in bulbs)
            dict[bulb] = dict.GetValueOrDefault(bulb, 0) + 1;

        foreach (var item in dict)
        {
            if (item.Value % 2 == 1)
                result.Add(item.Key);
        }

        return result.Order().ToList();
    }
}
