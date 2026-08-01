
namespace Algorithms.Tree.Medium;

public static class TreeMediumRunner
{
    public static void Run()
    {
        // 538: Convert BST to Greater Tree
        ConvertBSTToGreaterTree.Run(new TreeNode(val: 4,
            left: new(1, new(0), new(2, null, new(3))),
            right: new(6, new(5), new(7, null, new(8)))));
    }
}