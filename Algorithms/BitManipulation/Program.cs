// Demo runner for 3 solution files; the README is the canonical ID-sorted index.
using Algorithms.BitManipulation.Easy;
using BitManipulation.Easy;

Console.WriteLine("=== BitManipulation Algorithms ===");

// --- Easy ------------------------------------------------------------
NumberOf1Bits.Run(1);
MinimumBitFlipsToConvertNumber.Run(10, 7);
SumOfValuesAtIndicesWithKSetBits.Run(new List<int>() { 5, 10, 1, 5, 2 }, 1);

