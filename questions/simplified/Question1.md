# Problem Statement

You need to determine how many times a dial, starting at 50, points to 0 after following a series of rotation instructions. Each instruction consists of a direction (L for left or R for right) followed by a distance, indicating how many clicks the dial should rotate. The dial wraps around from 0 to 99 and vice versa.

## Input Format

A list of rotation instructions, each formatted as either 'L' or 'R' followed by a number (e.g., 'L68' or 'R19').

## Output Format

An integer representing the number of times the dial points to 0 during the rotations.

## Sample Input

```
L68
L30
R48
L5
R60
L55
L1
L99
R14
L82

```

## Sample Output

```
3
```