# Problem Statement

You need to calculate the total joltage output from a series of batteries. For each bank, you have a string of digits that represent the battery outputs. You must turn on exactly twelve batteries, and the joltage output is formed by the digits of the batteries that are turned on, resulting in a string with twelve digits. The aim is to maximize the output joltage by selectively turning off batteries. What is the new total output joltage for the given input strings?

## Input Format

A list of strings where each string consists of twelve or more digits representing battery outputs.

## Output Format

A single integer representing the total output joltage obtained by summing the maximum possible joltage outputs from each bank.

## Sample Input

```
987654321111111
811111111111119
234234234234278
818181911112111
```

## Sample Output

```
3121910778619
```