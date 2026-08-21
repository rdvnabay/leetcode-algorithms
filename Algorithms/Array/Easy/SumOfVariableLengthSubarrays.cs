using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Easy;

public static class SumOfVariableLengthSubarrays
{
    /*
     * Example 1:

Input: nums = [2,3,1]

Output: 11

Explanation:

i	Subarray	Sum
0	nums[0] = [2]	2
1	nums[0 ... 1] = [2, 3]	5
2	nums[1 ... 2] = [3, 1]	4
Total Sum	 	11

     */

    public static int Run(int[] nums)
    {
        int total = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int max = System.Math.Max(0, i - nums[i]);

            for (int j = max; j <= i; j++)
            {
                total+= nums[j];
            }

        }

        return total;
    }
}
