# LeetCode Algorithms

A structured, modular collection of **LeetCode** solutions written in C# (.NET 8), organized by **Topic** and **Difficulty**.

---

## Repository Architecture

Each algorithm topic is structured as an independent Console Application referencing a shared `Common` class library (`ListNode`, `TreeNode`):

```
Algorithms/
+-- Common/                 (Shared data structures: ListNode, TreeNode)
+-- Array/
|   +-- Easy/               (Solution implementations)
|   +-- Medium/
|   +-- Hard/
|   +-- Program.cs          (Main runner: Easy -> Medium -> Hard, A-Z)
|   +-- Array.csproj        (Topic Console App)
|   +-- README.md           (Topic Problem Index)
+-- BinarySearch/
+-- HashTable/
+-- ... (14 Topic Projects)
```

---

## Statistics

> The counts below represent solution files, not verified accepted solutions. See [AUDIT.md](AUDIT.md) for reviewed statuses.

| Metric | Count |
|--------|-------|
| Solution Files | **181** |
| Easy | **165** |
| Medium | **15** |
| Hard | **1** |
| Topic Categories | **14** |

---

## Topics Overview

| Topic Category | Total | Easy | Medium | Hard | Documentation |
|----------------|-------|------|--------|------|---------------|
| **Array** | 59 | 51 | 8 | 0 | [Overview](Algorithms/Array/README.md) |
| **Backtracking** | 1 | 0 | 1 | 0 | [Overview](Algorithms/Backtracking/README.md) |
| **BinarySearch** | 3 | 3 | 0 | 0 | [Overview](Algorithms/BinarySearch/README.md) |
| **BitManipulation** | 1 | 1 | 0 | 0 | [Overview](Algorithms/BitManipulation/README.md) |
| **DynamicProgramming** | 4 | 4 | 0 | 0 | [Overview](Algorithms/DynamicProgramming/README.md) |
| **Greedy** | 3 | 3 | 0 | 0 | [Overview](Algorithms/Greedy/README.md) |
| **HashTable** | 18 | 17 | 0 | 1 | [Overview](Algorithms/HashTable/README.md) |
| **LinkedList** | 6 | 4 | 2 | 0 | [Overview](Algorithms/LinkedList/README.md) |
| **Math** | 43 | 42 | 1 | 0 | [Overview](Algorithms/Math/README.md) |
| **Sorting** | 1 | 1 | 0 | 0 | [Overview](Algorithms/Sorting/README.md) |
| **Stack** | 4 | 4 | 0 | 0 | [Overview](Algorithms/Stack/README.md) |
| **String** | 33 | 31 | 2 | 0 | [Overview](Algorithms/String/README.md) |
| **Tree** | 4 | 3 | 1 | 0 | [Overview](Algorithms/Tree/README.md) |
| **TwoPointers** | 1 | 1 | 0 | 0 | [Overview](Algorithms/TwoPointers/README.md) |

---

## Audit Status Model

A solution file is not considered solved only because the `.cs` file exists. Reviewed implementations are classified with these statuses:

- `Solved` — implementation satisfies the problem requirements for the reviewed cases and constraints.
- `Incomplete` — implementation is unfinished or returns a placeholder result.
- `Incorrect` — implementation can produce an incorrect result or has broken control flow.
- `Constraint Violation` — output may be correct, but the implementation violates an explicit LeetCode requirement.
- `Needs Optimization` — implementation is functionally valid but has a clearly better time or auxiliary-space approach worth documenting.

The current verified findings are tracked in [AUDIT.md](AUDIT.md).

---

## Topic Classification Policy

Physical solution files use one canonical topic location:

```
Algorithms/<PrimaryTopic>/<Difficulty>/<ProblemName>.cs
```

When LeetCode assigns multiple topics to the same problem:

1. The topic selected when the problem was discovered/filtered is treated as the **Primary Topic**.
2. The solution should have one canonical physical location.
3. Additional LeetCode topics should be documented as **Secondary Topics** rather than duplicating the same solution file across multiple topic directories.
4. Alternative implementations are allowed when intentionally documented as alternative solutions rather than accidental duplicates.

---

## How to Run Solutions

Build the entire solution:

```bash
dotnet build LeetCode.sln
```

Run a specific topic:

```bash
dotnet run --project Algorithms/Array/Array.csproj
dotnet run --project Algorithms/HashTable/HashTable.csproj
```

---

## Conventions

- Solution files are organized under `Algorithms/<Topic>/<Difficulty>/<ProblemName>.cs`.
- Namespaces follow `Algorithms.<Topic>.<Difficulty>`.
- `Program.cs` in each topic runs solutions ordered by difficulty (`Easy` -> `Medium` -> `Hard`) and then alphabetically (`A-Z`).
- Audit findings must be based on implementation review; unreviewed files must not automatically be classified as `Solved`.
