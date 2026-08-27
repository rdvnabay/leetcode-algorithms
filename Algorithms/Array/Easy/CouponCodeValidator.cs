/**
 * @id         3606
 * @title      Coupon Code Validator
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/coupon-code-validator/
 */
namespace Array.Easy;

public static class CouponCodeValidator
{
    public static IList<string> Run(string[] code, string[] businessLine, bool[] isActive)
    {
        HashSet<string> set = new() { "electronics", "grocery", "pharmacy", "restaurant" };
        Dictionary<string, string> dict = new();

        for (int i = 0; i < code.Length; i++)
        {
            if (!isActive[i])
                continue;

            if (!set.Contains(businessLine[i]))
                continue;

            if (string.IsNullOrEmpty(code[i]))
                continue;

            bool isValidCoupon = true;

            for (int j = 0; j < code[i].Length; j++)
            {
                char letter = code[i][j];
                if (!char.IsLetterOrDigit(letter) && letter != '_')
                {
                    isValidCoupon = false;
                    break;
                }
            }

            if (isValidCoupon)
            {
                dict.Add(businessLine[i], code[i]);
            }
        }

        return dict.OrderBy(x=>x.Key).ThenBy(x=>x.Value).Select(x=>x.Value).ToList();
    }
}
