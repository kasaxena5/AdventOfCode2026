# Problem Statement

You are given a list of fresh ingredient ID ranges and a list of available ingredient IDs. Each range is inclusive, meaning both ends are part of the range. Determine how many of the available ingredient IDs are considered fresh, which means they fall into any of the given ranges.

## Input Format

The input consists of several lines where the first part contains fresh ingredient ID ranges (in 'a-b' format), followed by a blank line, and then a list of available ingredient IDs (one per line).

## Output Format

Output a single integer: the number of fresh ingredient IDs.

## Sample Input

```
3-5
10-14
16-20
12-18

1
5
8
11
17
32
```

## Sample Output

```
3
```