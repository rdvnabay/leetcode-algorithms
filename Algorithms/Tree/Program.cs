// Demo runner for 4 solution files; the README is the canonical ID-sorted index.
using Algorithms.Common;
using Algorithms.Tree.Easy;
using Algorithms.Tree.Medium;

Console.WriteLine("=== Tree Algorithms ===");

// --- Easy ------------------------------------------------------------
ConvertSortedArrayToBinarySearchTree.Run(new int[] { -10, -3, 0, 5, 9 });
SameTree.Run(new TreeNode(1, left: new TreeNode(2)), new TreeNode(1, right: new TreeNode(2)));

// --- Medium ------------------------------------------------------------


