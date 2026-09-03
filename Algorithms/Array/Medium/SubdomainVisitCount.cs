/**
 * @id         811
 * @title      Subdomain Visit Count
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/subdomain-visit-count/
 */
namespace Array.Medium;

public static class SubdomainVisitCount
{
    public static IList<string> Run(string[] cpdomains)
    {
        Dictionary<string, int> dict = new();

        foreach (var cpdomain in cpdomains)
        {
            string[] parts = cpdomain.Split(' ');
            int visitCount = int.Parse(parts[0]);
            string domain = parts[1];

            dict[domain] = dict.GetValueOrDefault(domain, 0) + visitCount;

            string[] subDomains = domain.Split('.');

            if (subDomains.Length == 3)
            {
                string subDomain = $"{subDomains[1]}.{subDomains[2]}";
                dict[subDomain] = dict.GetValueOrDefault(subDomain, 0) + visitCount;
            }

            dict[subDomains[^1]] = dict.GetValueOrDefault(subDomains[^1], 0) + visitCount;
        }

        List<string> result = new();
        
        foreach (var item in dict)
            result.Add($"{item.Value} {item.Key}");

        return result;
    }
}
