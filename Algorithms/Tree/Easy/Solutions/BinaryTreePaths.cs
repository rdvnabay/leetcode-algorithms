using Algorithms.Common;
using System.Text;

namespace Algorithms.Tree.Easy.Solutions;

public static class BinaryTreePaths
{
    public static IList<string> Run(TreeNode root)
    {
        StringBuilder sb = new();
        Recursive(root, sb);
        return null;
    }

    static void Recursive(TreeNode root, StringBuilder sb)
    {
        if (root.left is not null)
        {
            sb.Append($"{root.val}->");
            root = root.left;
        }

        if (root.right is not null)
        {
            sb.Append($"{root.val}->");
            root = root.right;
        }

        else if (root.left is null && root.right is null)
        {
            sb.Append(root.val);
        }

        Recursive(root, sb);
    }
}
