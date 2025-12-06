# Problem Statement

You are in a scenario where you need to solve math problems presented by cephalopods. The problems consist of a list of numbers that need to be added or multiplied together. The unique aspect of these problems is that they are formatted in a columnar layout with the most significant digit at the top and the least significant digit at the bottom. Each number is in its own column, with operations provided at the bottom of each set of numbers. Your task is to solve all problems and provide the grand total of the results.

## Input Format

A matrix where each column contains numbers and each operation is located at the bottom of the columns. Columns are separated by spaces.

## Output Format

An integer representing the grand total of all problem results.

## Sample Input

```
123 328  51 64
 45 64  387 23
  6 98  215 314
*   +   *   +

```

## Sample Output

```
3263827
```

## Note
In the sample input above, the calculations are done from rightmost to leftmost column as follows:
```
4 + 431 + 623 = 1058
175 * 581 * 32 = 3253600
8 + 248 + 369 = 625
356 * 24 * 1 = 8544
1058 + 3253600 + 625 + 8544 = 3263827.
```
