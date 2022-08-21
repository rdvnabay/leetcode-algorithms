namespace Algorithms.Solutions.Easy;

public class ReverseString
{
    public static void Run(char[] s)
    {
        Solution1(s); // for loop
        //Solution2(s); // while loop
        //Solution3(s, left: 0, right: s.Length - 1);  // recursive method
    }

    // Runtime: 248 ms, faster than 98.09% of C# online submissions for Reverse String.
    // Memory Usage: 61.5 MB, less than 5.41% of C# online submissions for Reverse String.
    private static void Solution1(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        for (int i = 0; i < s.Length / 2; i++)
        {
            char tempLeft = s[left];
            s[left] = s[right];
            s[right] = tempLeft;

            left++;
            right--;
        }
    }


    // Runtime: 387 ms, faster than 40.07% of C# online submissions for Reverse String.
    // Memory Usage: 47.5 MB, less than 87.27% of C# online submissions for Reverse String.
    private static void Solution2(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char tempLeft = s[left];
            s[left] = s[right];
            s[right] = tempLeft;

            left++;
            right--;
        }
    }


    // Runtime: 420 ms, faster than 22.90% of C# online submissions for Reverse String.
    // Memory Usage: 49.3 MB, less than 20.38% of C# online submissions for Reverse String.
    private static void Solution3(char[] s, int left, int right)
    {
        if (left > right)
            return;

        char tempLeft = s[left];
        s[left] = s[right];
        s[right] = tempLeft;

        Solution3(s, ++left, --right);
    }
}
