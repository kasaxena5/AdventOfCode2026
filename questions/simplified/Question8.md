# Problem Statement

You are given a grid representing rolls of paper, denoted by '@'. A forklift can access a roll of paper if fewer than four rolls of paper are present in the eight adjacent positions. Your task is to determine how many total rolls of paper can be removed by the forklifts, repeating this process until no more rolls are accessible.

## Input Format

A grid of characters where '@' indicates a roll of paper and '.' indicates an empty space.

## Output Format

An integer representing the total number of rolls of paper that can be removed.

## Sample Input

```
..@@.@@@@.
@@@.@.@.@@
@@@@@.@.@@
@.@@@@..@.
@@.@@@@.@@
.@@@@@@@.@
.@.@.@.@@@
@.@@@.@@@@
.@@@@@@@@.
@.@.@@@.@.
```

## Sample Output

```
43
```