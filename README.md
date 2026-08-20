# LeetCode Algorithms

A modular collection of LeetCode solutions written in C# (.NET 8), organized by topic and difficulty.

## Statistics

| Metric | Count |
|---|---:|
| Solution files | 318 |
| Unique LeetCode problems | 315 |
| Easy (unique) | 276 |
| Medium (unique) | 38 |
| Hard (unique) | 1 |
| Topic categories | 14 |

> Counts use official LeetCode difficulty metadata. Duplicate files count once in the unique totals.

## Topics

| Topic | Files | Unique | Easy | Medium | Hard |
|---|---:|---:|---:|---:|---:|
| [Array](Algorithms/Array/README.md) | 102 | 102 | 73 | 29 | 0 |
| [Backtracking](Algorithms/Backtracking/README.md) | 1 | 1 | 0 | 1 | 0 |
| [BinarySearch](Algorithms/BinarySearch/README.md) | 3 | 3 | 3 | 0 | 0 |
| [BitManipulation](Algorithms/BitManipulation/README.md) | 1 | 1 | 1 | 0 | 0 |
| [DynamicProgramming](Algorithms/DynamicProgramming/README.md) | 4 | 4 | 4 | 0 | 0 |
| [Greedy](Algorithms/Greedy/README.md) | 3 | 3 | 2 | 1 | 0 |
| [HashTable](Algorithms/HashTable/README.md) | 18 | 18 | 17 | 0 | 1 |
| [LinkedList](Algorithms/LinkedList/README.md) | 6 | 6 | 4 | 2 | 0 |
| [Math](Algorithms/Math/README.md) | 87 | 87 | 85 | 2 | 0 |
| [Sorting](Algorithms/Sorting/README.md) | 1 | 1 | 1 | 0 | 0 |
| [Stack](Algorithms/Stack/README.md) | 4 | 4 | 4 | 0 | 0 |
| [String](Algorithms/String/README.md) | 83 | 83 | 81 | 2 | 0 |
| [Tree](Algorithms/Tree/README.md) | 4 | 4 | 3 | 1 | 0 |
| [TwoPointers](Algorithms/TwoPointers/README.md) | 1 | 1 | 1 | 0 | 0 |

## Repository audit

Static review found **21 incomplete** and **2 clearly incorrect or suspicious** implementations. These files still compile; the labels describe implementation completeness, not compiler status.

### Incomplete implementations

- [922 - Sort Array By Parity II](Algorithms/Array/Easy/SortArrayByParityII.cs)
- [2482 - Difference Between Ones and Zeros in Row and Column](Algorithms/Array/Medium/DifferenceBetweenOnesAndZerosInRowAndColumn.cs)
- [3446 - Sort Matrix by Diagonals](Algorithms/Array/Medium/SortMatrixByDiagonals.cs)
- [78 - Subsets](Algorithms/Array/Medium/Subsets.cs)
- [139 - Word Break](Algorithms/Array/Medium/WordBreak.cs)
- [17 - Letter Combinations of a Phone Number](Algorithms/Backtracking/Medium/LetterCombinationsOfAPhoneNumber.cs)
- [495 - Teemo Attacking](Algorithms/Greedy/Easy/TeemoAttacking.cs)
- [706 - Design HashMap](Algorithms/HashTable/Easy/DesignHashMap.cs)
- [1160 - Find Words That Can Be Formed by Characters](Algorithms/HashTable/Easy/FindWordsThatCanBeFormedByCharacters.cs)
- [21 - Merge Two Sorted Lists](Algorithms/LinkedList/Easy/MergeTwoSortedLists.cs)
- [2 - Add Two Numbers](Algorithms/LinkedList/Medium/AddTwoNumbers.cs)
- [2843 - Count Symmetric Integers](Algorithms/Math/Easy/CountSymmetricIntegers.cs)
- [509 - Fibonacci Number](Algorithms/Math/Easy/FibonacciNumber.cs)
- [1304 - Find N Unique Integers Sum up to Zero](Algorithms/Math/Easy/FindNUniqueIntegersSumUpToZero.cs)
- [2138 - Divide a String Into Groups of Size k](Algorithms/String/Easy/DivideAStringIntoGroupsOfSizeK.cs)
- [500 - Keyboard Row](Algorithms/String/Easy/KeyboardRow.cs)
- [383 - Ransom Note](Algorithms/String/Easy/RansomNote.cs)
- [821 - Shortest Distance to a Character](Algorithms/String/Easy/ShortestDistanceToACharacter.cs)
- [680 - Valid Palindrome II](Algorithms/String/Easy/ValidPalindromeII.cs)
- [257 - Binary Tree Paths](Algorithms/Tree/Easy/BinaryTreePaths.cs)
- [108 - Convert Sorted Array to Binary Search Tree](Algorithms/Tree/Easy/ConvertSortedArrayToBinarySearchTree.cs)

### Needs review

- [953 - Verifying an Alien Dictionary](Algorithms/HashTable/Easy/VerifyingAnAlienDictionary.cs)
- [28 - Find the Index of the First Occurrence in a String](Algorithms/String/Easy/FindTheIndexOfTheFirstOccurrenceInAString.cs)

### Duplicate problems

- **1207 - Unique Number of Occurrences**
  - [Algorithms/Array/Easy/UniqueNumberOfOccurrences.cs](Algorithms/Array/Easy/UniqueNumberOfOccurrences.cs)
  - [Algorithms/HashTable/Easy/UniqueNumberOfOccurrences.cs](Algorithms/HashTable/Easy/UniqueNumberOfOccurrences.cs)
- **1304 - Find N Unique Integers Sum up to Zero**
  - [Algorithms/Array/Easy/FindNUniqueIntegersSumUpToZero.cs](Algorithms/Array/Easy/FindNUniqueIntegersSumUpToZero.cs)
  - [Algorithms/Math/Easy/FindNUniqueIntegersSumUpToZero.cs](Algorithms/Math/Easy/FindNUniqueIntegersSumUpToZero.cs)
- **1331 - Rank Transform of an Array**
  - [Algorithms/Array/Easy/RankTransformOfAnArray.cs](Algorithms/Array/Easy/RankTransformOfAnArray.cs)
  - [Algorithms/HashTable/Easy/RankTransformOfAnArray.cs](Algorithms/HashTable/Easy/RankTransformOfAnArray.cs)

### Metadata mismatch

- [55 - Jump Game](Algorithms/Greedy/Easy/JumpGame.cs) is in `Easy` but LeetCode classifies it as **Medium**.

## Ordering convention

- README indexes use the LeetCode problem ID as the canonical order.
- Descriptive file names are retained for discoverability and IDE search.
- Every solution begins with verified ID, title, topic, difficulty, and link metadata.

## Build and run

```bash
dotnet build LeetCode.sln
dotnet run --project Algorithms/Array/Array.csproj
```

Topic `Program.cs` files are lightweight demo runners; README files are the complete indexes.

## Solution header

```csharp
/**
 * @id         2481
 * @title      Minimum Cuts to Divide a Circle
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-cuts-to-divide-a-circle/
 */
```
