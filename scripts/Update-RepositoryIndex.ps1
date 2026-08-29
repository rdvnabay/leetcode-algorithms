param([Parameter(Mandatory = $true)][string] $CatalogPath)

$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$algorithms = Join-Path $root 'Algorithms'
$levels = @{ 1 = 'Easy'; 2 = 'Medium'; 3 = 'Hard' }

function Normalize([string] $value) { ($value -replace '[^A-Za-z0-9]', '').ToLowerInvariant() }
function Topic-Slug([string] $value) { [regex]::Replace($value, '(?<!^)([A-Z])', '-$1').ToLowerInvariant() }

$catalog = (Get-Content $CatalogPath -Raw | ConvertFrom-Json).stat_status_pairs
$lookup = @{}
foreach ($entry in $catalog) {
    $key = Normalize $entry.stat.question__title
    if (-not $lookup.ContainsKey($key)) { $lookup[$key] = $entry }
}

$incomplete = @(
    'Algorithms/Array/Easy/FindTheHighestAltitude.cs',
    'Algorithms/Array/Easy/SortArrayByParityII.cs',
    'Algorithms/Array/Easy/TransformedArray.cs',
    'Algorithms/Array/Medium/CapacityToShipPackagesWithinDDays.cs',
    'Algorithms/Array/Medium/CountSquareSubmatricesWithAllOnes.cs',
    'Algorithms/Array/Medium/DifferenceBetweenOnesAndZerosInRowAndColumn.cs',
    'Algorithms/Array/Medium/SortMatrixByDiagonals.cs',
    'Algorithms/Array/Medium/Subsets.cs',
    'Algorithms/Array/Medium/WordBreak.cs',
    'Algorithms/Backtracking/Medium/LetterCombinationsOfAPhoneNumber.cs',
    'Algorithms/Greedy/Easy/LargestIntegerWithGivenDigitSum.cs',
    'Algorithms/Greedy/Easy/MinimumMovesToConvertString.cs',
    'Algorithms/Greedy/Easy/TeemoAttacking.cs',
    'Algorithms/HashTable/Easy/CountPairsOfSimilarStrings.cs',
    'Algorithms/HashTable/Easy/DesignHashMap.cs',
    'Algorithms/HashTable/Easy/FindCommonCharacters.cs',
    'Algorithms/HashTable/Easy/FindResultantArrayAfterRemovingAnagrams.cs',
    'Algorithms/HashTable/Easy/FindWordsThatCanBeFormedByCharacters.cs',
    'Algorithms/LinkedList/Easy/MergeTwoSortedLists.cs',
    'Algorithms/LinkedList/Medium/AddTwoNumbers.cs',
    'Algorithms/Math/Easy/CountSymmetricIntegers.cs',
    'Algorithms/Math/Easy/FibonacciNumber.cs',
    'Algorithms/Math/Easy/FindNUniqueIntegersSumUpToZero.cs',
    'Algorithms/Math/Easy/FindTheKBeautyOfANumber.cs',
    'Algorithms/String/Easy/DivideAStringIntoGroupsOfSizeK.cs',
    'Algorithms/String/Easy/KeyboardRow.cs',
    'Algorithms/String/Easy/MaximumNumberOfBalloons.cs',
    'Algorithms/String/Easy/RansomNote.cs',
    'Algorithms/String/Easy/ShortestDistanceToACharacter.cs',
    'Algorithms/String/Easy/StringMatchingInAnArray.cs',
    'Algorithms/String/Easy/ValidPalindromeII.cs',
    'Algorithms/String/Medium/ConstructSmallestNumberFromDIString.cs',
    'Algorithms/String/Medium/MinimumNumberOfStepsToMakeTwoStringsAnagram.cs',
    'Algorithms/String/Medium/TheKThLexicographicalStringOfAllHappyStringsOfLengthN.cs',
    'Algorithms/Tree/Easy/BinaryTreePaths.cs',
    'Algorithms/Tree/Easy/ConvertSortedArrayToBinarySearchTree.cs'
)

$needsReview = @(
    'Algorithms/Array/Easy/BuyTwoChocolates.cs',
    'Algorithms/Array/Easy/FindTheMiddleIndexInArray.cs',
    'Algorithms/Array/Easy/SplitTheArray.cs',
    'Algorithms/Greedy/Easy/BuyTwoChocolates.cs',
    'Algorithms/Greedy/Easy/JumpGame.cs',
    'Algorithms/HashTable/Easy/SmallestMissingMultipleOfK.cs',
    'Algorithms/HashTable/Easy/VerifyingAnAlienDictionary.cs',
    'Algorithms/Math/Easy/FindTheChildWhoHasTheBallAfterKSeconds.cs',
    'Algorithms/String/Easy/FindTheIndexOfTheFirstOccurrenceInAString.cs',
    'Algorithms/String/Easy/ShortestDistancetoTargetStringInACircularArray.cs'
)

$files = Get-ChildItem $algorithms -Recurse -File -Filter '*.cs' |
    Where-Object { $_.Directory.Name -in @('Easy', 'Medium', 'Hard') }

$rows = foreach ($file in $files) {
    $key = Normalize $file.BaseName
    if (-not $lookup.ContainsKey($key)) { throw "Metadata missing: $($file.FullName)" }
    $entry = $lookup[$key]
    $title = ([string] $entry.stat.question__title).Trim()
    $difficulty = $levels[[int] $entry.difficulty.level]
    $topic = $file.Directory.Parent.Name
    $slug = [string] $entry.stat.question__title_slug
    $relative = $file.FullName.Substring($root.Length + 1).Replace('\', '/')
    $header = @"
/**
 * @id         $($entry.stat.frontend_question_id)
 * @title      $title
 * @topic      $topic
 * @difficulty $difficulty
 * @link       https://leetcode.com/problems/$slug/
 */
"@
    $content = Get-Content $file.FullName -Raw
    $content = $content -replace '^/\*\*[\s\S]*?\*/\s*', ''
    [IO.File]::WriteAllText($file.FullName, $header + "`r`n" + $content.TrimStart(), [Text.UTF8Encoding]::new($false))
    $status = if ($incomplete -contains $relative) { 'Incomplete' } elseif ($needsReview -contains $relative) { 'Needs review' } else { 'Implemented' }
    [pscustomobject]@{
        Id = [int] $entry.stat.frontend_question_id; Title = $title; Slug = $slug
        Topic = $topic; Difficulty = $difficulty; FolderDifficulty = $file.Directory.Name
        Relative = $relative; TopicRelative = "$($file.Directory.Name)/$($file.Name)"; Status = $status
    }
}

foreach ($group in ($rows | Group-Object Topic | Sort-Object Name)) {
    $items = $group.Group | Sort-Object Id, Relative
    $lines = [Collections.Generic.List[string]]::new()
    $lines.Add("# $($group.Name) Algorithms"); $lines.Add('')
    $lines.Add('LeetCode solutions indexed by problem number. Descriptive file names remain easy to search alphabetically.'); $lines.Add('')
    $lines.Add('## Summary'); $lines.Add('')
    $lines.Add('| Files | Unique | Easy | Medium | Hard | Incomplete | Needs review |')
    $lines.Add('|---:|---:|---:|---:|---:|---:|---:|')
    $lines.Add("| $($items.Count) | $(($items.Id | Sort-Object -Unique).Count) | $(($items | Where-Object Difficulty -eq 'Easy').Count) | $(($items | Where-Object Difficulty -eq 'Medium').Count) | $(($items | Where-Object Difficulty -eq 'Hard').Count) | $(($items | Where-Object Status -eq 'Incomplete').Count) | $(($items | Where-Object Status -eq 'Needs review').Count) |")
    $lines.Add(''); $lines.Add('## Solutions'); $lines.Add('')
    $lines.Add('| ID | Problem | Difficulty | Status | Solution |')
    $lines.Add('|---:|---|---|---|---|')
    foreach ($item in $items) {
        $lines.Add("| $($item.Id) | [$($item.Title)](https://leetcode.com/problems/$($item.Slug)/) | $($item.Difficulty) | $($item.Status) | [$([IO.Path]::GetFileName($item.Relative))]($($item.TopicRelative)) |")
    }
    $lines.Add(''); $lines.Add('## Run'); $lines.Add(''); $lines.Add('```bash')
    $lines.Add("dotnet run --project Algorithms/$($group.Name)/$($group.Name).csproj")
    $lines.Add('```')
    [IO.File]::WriteAllText((Join-Path $algorithms "$($group.Name)/README.md"), ($lines -join "`r`n") + "`r`n", [Text.UTF8Encoding]::new($false))

    $programPath = Join-Path $algorithms "$($group.Name)/Program.cs"
    if (Test-Path $programPath) {
        $program = Get-Content $programPath -Raw
        $program = $program -replace '^// Demo runner[^\r\n]*\r?\n', ''
        $banner = "// Demo runner for $($items.Count) solution files; the README is the canonical ID-sorted index.`r`n"
        [IO.File]::WriteAllText($programPath, $banner + $program, [Text.UTF8Encoding]::new($false))
    }
}

$unique = $rows | Sort-Object Id, Relative | Group-Object Id | ForEach-Object { $_.Group[0] }
$duplicates = $rows | Group-Object Id | Where-Object Count -gt 1 | Sort-Object { [int] $_.Name }
$mismatches = $rows | Where-Object { $_.FolderDifficulty -ne $_.Difficulty }
$rootLines = [Collections.Generic.List[string]]::new()
$rootLines.Add('# LeetCode Algorithms'); $rootLines.Add('')
$rootLines.Add('A modular collection of LeetCode solutions written in C# (.NET 8), organized by topic and difficulty.'); $rootLines.Add('')
$rootLines.Add('## Statistics'); $rootLines.Add('')
$rootLines.Add('| Metric | Count |'); $rootLines.Add('|---|---:|')
$rootLines.Add("| Solution files | $($rows.Count) |")
$rootLines.Add("| Unique LeetCode problems | $($unique.Count) |")
$rootLines.Add("| Easy (unique) | $(($unique | Where-Object Difficulty -eq 'Easy').Count) |")
$rootLines.Add("| Medium (unique) | $(($unique | Where-Object Difficulty -eq 'Medium').Count) |")
$rootLines.Add("| Hard (unique) | $(($unique | Where-Object Difficulty -eq 'Hard').Count) |")
$rootLines.Add("| Topic categories | $(($rows | Group-Object Topic).Count) |")
$rootLines.Add("| Incomplete files | $(($rows | Where-Object Status -eq 'Incomplete').Count) |")
$rootLines.Add("| Needs-review files | $(($rows | Where-Object Status -eq 'Needs review').Count) |")
$rootLines.Add(''); $rootLines.Add('> Difficulty counts use official LeetCode metadata. Duplicate files count once in unique totals.'); $rootLines.Add('')
$rootLines.Add('## Topics'); $rootLines.Add('')
$rootLines.Add('| Topic | Files | Unique | Easy | Medium | Hard |')
$rootLines.Add('|---|---:|---:|---:|---:|---:|')
foreach ($group in ($rows | Group-Object Topic | Sort-Object Name)) {
    $g = $group.Group
    $rootLines.Add("| [$($group.Name)](Algorithms/$($group.Name)/README.md) | $($g.Count) | $(($g.Id | Sort-Object -Unique).Count) | $(($g | Where-Object Difficulty -eq 'Easy').Count) | $(($g | Where-Object Difficulty -eq 'Medium').Count) | $(($g | Where-Object Difficulty -eq 'Hard').Count) |")
}
$rootLines.Add(''); $rootLines.Add('## Repository audit'); $rootLines.Add('')
$rootLines.Add('### Incomplete implementations'); $rootLines.Add('')
foreach ($item in ($rows | Where-Object Status -eq 'Incomplete' | Sort-Object Id)) { $rootLines.Add("- [$($item.Id) - $($item.Title)]($($item.Relative))") }
$rootLines.Add(''); $rootLines.Add('### Needs review'); $rootLines.Add('')
foreach ($item in ($rows | Where-Object Status -eq 'Needs review' | Sort-Object Id)) { $rootLines.Add("- [$($item.Id) - $($item.Title)]($($item.Relative))") }
$rootLines.Add(''); $rootLines.Add('### Duplicate problems'); $rootLines.Add('')
foreach ($duplicate in $duplicates) {
    $rootLines.Add("- **$($duplicate.Name) - $($duplicate.Group[0].Title)**")
    foreach ($item in $duplicate.Group) { $rootLines.Add("  - [$($item.Relative)]($($item.Relative))") }
}
$rootLines.Add(''); $rootLines.Add('### Difficulty-folder mismatches'); $rootLines.Add('')
if ($mismatches.Count -eq 0) { $rootLines.Add('- None.') } else { foreach ($item in $mismatches) { $rootLines.Add("- [$($item.Id) - $($item.Title)]($($item.Relative)): folder ``$($item.FolderDifficulty)``, official **$($item.Difficulty)**.") } }
$rootLines.Add(''); $rootLines.Add('## Ordering convention'); $rootLines.Add('')
$rootLines.Add('- README indexes use the LeetCode problem ID as the canonical order.')
$rootLines.Add('- Descriptive file names are retained for alphabetical IDE and repository search.')
$rootLines.Add('- Every solution begins with verified ID, title, topic, difficulty, and link metadata.')
$rootLines.Add(''); $rootLines.Add('## Build and run'); $rootLines.Add(''); $rootLines.Add('```bash')
$rootLines.Add('dotnet build LeetCode.sln'); $rootLines.Add('dotnet run --project Algorithms/Array/Array.csproj'); $rootLines.Add('```')
$rootLines.Add(''); $rootLines.Add('Topic `Program.cs` files are demo runners; topic README files are the complete indexes.')
$rootLines.Add(''); $rootLines.Add('## Solution header'); $rootLines.Add(''); $rootLines.Add('```csharp')
$rootLines.Add('/**'); $rootLines.Add(' * @id         2481'); $rootLines.Add(' * @title      Minimum Cuts to Divide a Circle')
$rootLines.Add(' * @topic      Math'); $rootLines.Add(' * @difficulty Easy')
$rootLines.Add(' * @link       https://leetcode.com/problems/minimum-cuts-to-divide-a-circle/')
$rootLines.Add(' */'); $rootLines.Add('```')
[IO.File]::WriteAllText((Join-Path $root 'README.md'), ($rootLines -join "`r`n") + "`r`n", [Text.UTF8Encoding]::new($false))

Write-Host "Indexed $($rows.Count) files / $($unique.Count) unique problems."
