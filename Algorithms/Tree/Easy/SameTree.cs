using Algorithms.Common;

namespace Algorithms.Tree.Easy;

public static class SameTree
{
    public static bool Run(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        if (p == null || q == null)
            return false;

        if (p.val != q.val)
            return false;

        bool isLeftNodeEqual = Run(p.left, q.left);
        bool isRightNodeEqual = Run(p.right, q.right);

        return isLeftNodeEqual && isRightNodeEqual;
    }
}
