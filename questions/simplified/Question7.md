# Problem Statement

You are given a grid representing rolls of paper with '@' symbols and empty spaces with '.'. A forklift can access a roll of paper if there are fewer than four rolls of paper in the eight adjacent positions. Determine how many rolls of paper can be accessed by a forklift.

## Input Format

A grid of characters consisting of '@' (rolls of paper) and '.' (empty positions). Each row is a string of equal length, and the grid has an arbitrary number of rows.

## Output Format

An integer representing the number of accessible rolls of paper by the forklift.

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
13
```