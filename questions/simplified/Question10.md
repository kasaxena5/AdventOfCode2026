# Problem Statement

You are given a list of fresh ingredient ID ranges and a separate list of available ingredient IDs. Each fresh ID range is inclusive, meaning both endpoints are considered fresh. An ingredient ID is considered fresh if it falls within any of the ranges. Your task is to determine how many unique ingredient IDs are considered fresh based on the provided ranges.

## Input Format

The input consists of two sections separated by a blank line. The first section contains lines representing fresh ingredient ID ranges (e.g., '3-5'). The second section contains available ingredient IDs, each on a new line.

## Output Format

Output a single number: the total count of unique fresh ingredient IDs.

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
14
```