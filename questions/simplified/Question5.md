# Problem Statement

You have a set of battery banks, each represented as a string of digits (1-9). Your goal is to find the maximum combined joltage output from each bank by selecting exactly two digits. The output joltage of a bank is formed by the two selected digits, in their original order (not rearranged). Sum the maximum outputs from all banks to get the total output joltage.

## Input Format

A series of strings, each representing a bank of batteries, e.g., '987654321111111'.

## Output Format

An integer representing the total output joltage from all battery banks.

## Sample Input

```
987654321111111
811111111111119
234234234234278
818181911112111
```

## Sample Output

```
357
```