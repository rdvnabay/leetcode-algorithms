/**
 * @id         2491
 * @title      Divide Players Into Teams of Equal Skill
 * @topic      HashTable
 * @difficulty Medium
 * @link       https://leetcode.com/problems/divide-players-into-teams-of-equal-skill/
 */
namespace HashTable.Medium;

public static class DividePlayersIntoTeamsOfEqualSkill
{
    public static long Run(int[] skill)
    {
        //3,2,5,1,3,4
        int total = 0;

        int sum = 0;

        Dictionary<int, int> dict = new();

        for (int i = 0; i < skill.Length; i++)
        {
            sum += skill[i];
            dict[skill[i]] = dict.GetValueOrDefault(skill[i], 0) + 1;
        }

        if (sum % (skill.Length / 2) != 0)
            return -1;

        int chemistry = sum / (skill.Length / 2);

        foreach (var item in dict)
        {
            int val = chemistry - item.Key;
            dict[item.Key]--;
            dict[val]--;
            //dict.Remove(item.Key)
        }

        return 0;
    }
}
