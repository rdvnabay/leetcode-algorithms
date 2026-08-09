# Repository Audit

This document records **verified findings** from implementation review. It is intentionally conservative: a solution is not marked `Solved` only because a source file exists.

## Status Definitions

| Status | Meaning |
|---|---|
| `Incomplete` | Implementation is unfinished or returns a placeholder result. |
| `Incorrect` | Implementation can produce wrong output or has broken control flow. |
| `Constraint Violation` | Implementation violates an explicit LeetCode requirement. |
| `Needs Optimization` | Implementation is usable but has a clearly better time/space approach worth tracking. |

## Incomplete Solutions

| Topic | Difficulty | Problem | File | Finding |
|---|---|---|---|---|
| Array | Medium | Subsets | `Algorithms/Array/Medium/Subsets.cs` | Iterates over `2^n` candidates but never constructs subsets and returns `null`. |
| Array | Easy | Sort Array By Parity II | `Algorithms/Array/Easy/SortArrayByParityII.cs` | Detects parity mismatches but swap/rearrangement logic is unfinished and returns `null`. |
| Array | Easy | Most Common Word | `Algorithms/Array/Easy/MostCommonWord.cs` | Only strips punctuation; banned-word/frequency logic is missing and the method returns an empty string. |
| String | Easy | Keyboard Row | `Algorithms/String/Easy/KeyboardRow.cs` | Keyboard-row sets are initialized but no word validation is implemented; method returns `null`. |
| LinkedList | Easy | Merge Two Sorted Lists | `Algorithms/LinkedList/Easy/MergeTwoSortedLists.cs` | Method immediately returns `null`. |
| LinkedList | Medium | Add Two Numbers | `Algorithms/LinkedList/Medium/AddTwoNumbers.cs` | Experimental logic assumes exactly three nodes per list and method returns `null`. |
| Tree | Easy | Binary Tree Paths | `Algorithms/Tree/Easy/BinaryTreePaths.cs` | Result collection is never produced and the method returns `null`; recursive flow also lacks a safe completed traversal structure. |

## Incorrect Solutions

| Topic | Difficulty | Problem | File | Finding |
|---|---|---|---|---|
| Array | Medium | 3Sum | `Algorithms/Array/Medium/3Sum.cs` | Matching triplets are added to a separate `hashset` collection while the returned `result` collection remains empty. `HashSet<int>` also cannot correctly represent duplicate values inside a triplet such as `[-1,-1,2]`. |
| Greedy | Easy | Jump Game | `Algorithms/Greedy/Easy/JumpGame.cs` | The algorithm tests only jumps from index `0`; it never advances a reachable frontier/current position, so reachable arrays can be classified incorrectly. |

## Constraint Violations

| Topic | Difficulty | Problem | File | Finding | Target |
|---|---|---|---|---|---|
| Array | Medium | Product of Array Except Self | `Algorithms/Array/Medium/ProductOfArrayExceptSelf.cs` | Uses `product / nums[i]` when no zero exists. LeetCode requires the solution to work without division. | `O(n)` time, `O(1)` auxiliary space excluding output, using prefix/suffix products. |

## Optimization Candidates

These entries are not classified as incorrect solely because a faster or lower-space solution exists.

| Topic | Difficulty | Problem | File | Current | Recommended Target |
|---|---|---|---|---|---|
| Array | Easy | Squares of a Sorted Array | `Algorithms/Array/Easy/SquaresOfASortedArray.cs` | Squares values and manually sorts with nested loops: `O(n^2)` time. | Two pointers: `O(n)` time, `O(n)` output space. |
| HashTable | Easy | Check If N and Its Double Exist | `Algorithms/HashTable/Easy/CheckIfNAndItsDoubleExist.cs` | Nested pair comparison: `O(n^2)` time, `O(1)` auxiliary space. | HashSet lookup: expected `O(n)` time, `O(n)` space. |
| Math | Easy | Perfect Number | `Algorithms/Math/Easy/PerfectNumber.cs` | Scans divisors toward `n` and stores divisors in a list. | Test divisor pairs only through `sqrt(n)`: `O(sqrt(n))` time and `O(1)` auxiliary space. |
| LinkedList | Easy | Reverse Linked List | `Algorithms/LinkedList/Easy/ReverseLinkedList.cs` | `O(n)` time but uses a stack and constructs a new list: `O(n)` auxiliary space. | In-place pointer reversal: `O(n)` time, `O(1)` auxiliary space. |

## Multi-Topic Classification Finding

`FindTheDifference.cs` currently exists under both `Algorithms/String/Easy` and `Algorithms/HashTable/Easy` with different implementations. This demonstrates why multi-topic classification needs an explicit policy.

Recommended repository rule:

- keep one canonical physical solution under the topic used as the **Primary Topic** when the problem was selected on LeetCode;
- document other LeetCode classifications as **Secondary Topics**;
- if multiple implementations are intentionally retained for learning, label them explicitly as alternative approaches instead of treating them as independent canonical copies.

## Audit Scope

This is an **initial verified audit**, not a claim that every one of the 181 solution files has been fully validated against every LeetCode test and constraint. Future audit passes should extend this file topic-by-topic and record status only after reviewing the implementation and the original problem requirements.
