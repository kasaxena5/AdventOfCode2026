# Problem Statement

Given a list of product ID ranges, identify invalid IDs that are formed by repeating a sequence of digits twice (e.g., 55, 6464, 123123). Each range is defined by a start and end number, and you need to find invalid IDs within these ranges. Count all the invalid IDs across all the ranges and return their sum.

## Input Format

A single line containing multiple ranges in the format 'start-end', separated by commas. For example: '11-22,95-115,998-1012'.

## Output Format

An integer representing the total sum of all invalid IDs found within the specified ranges.

## Sample Input

```
11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
```

## Sample Output

```
1227775554
```