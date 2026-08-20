/**
 * @id         1773
 * @title      Count Items Matching a Rule
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-items-matching-a-rule/
 */
namespace String.Easy;

public static class CountItemsMatchingARule
{
    //new List<string> { "phone", "blue", "pixel" },
    //new List<string> { "computer", "silver", "lenovo" },
    //new List<string> { "phone", "gold", "iphone" }
    //Type phone

    //type color name
    public static int Run(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        Dictionary<string, int> rules = new()
        {
            { "type" , 0 },
            { "color" , 1 },
            { "name" , 2 },
        };

        int counter = 0;
        int ruleIndex = rules[ruleKey];

        for (int i = 0; i < items.Count; i++)
        {
            string value = items[i][ruleIndex];
            if (ruleValue == value)
                counter++;
        }

        return counter;
    }
}


