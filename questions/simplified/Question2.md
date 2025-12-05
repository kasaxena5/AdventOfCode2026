# Problem Statement

You have a dial that starts pointing at 50. It can rotate left (L) or right (R), and you want to count how many times the dial points at 0 during these rotations. A rotation can position the dial at 0 either during the rotation or at the end of it. Given a series of rotation instructions, determine the total number of times the dial points to 0.

## Input Format

A series of rotation instructions in the format: `<Direction><Amount>` (e.g., 'L68', 'R48'). Each instruction is given in a new line until the end of input.

## Output Format

An integer representing the total number of times the dial points at 0 during the movements.

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
6
```