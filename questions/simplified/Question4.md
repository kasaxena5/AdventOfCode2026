# Problem Statement

Given a list of ID ranges, determine the sum of invalid IDs. An ID is considered invalid if it consists solely of a sequence of digits that repeats at least twice (e.g., 12341234, 121212).

## Input Format

A list of ID ranges represented as strings in the format 'start-end'.

## Output Format

An integer representing the total sum of all invalid IDs across the provided ranges.

## Sample Input

```
11-22
95-115
998-1012
1188511880-1188511890
222220-222224
1698522-1698528
446443-446449
38593856-38593862
565653-565659
824824821-824824827
2121212118-2121212124
```

## Sample Output

```
4174379265
```