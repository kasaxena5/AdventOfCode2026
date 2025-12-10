# Problem Statement

You are given the indicator light diagrams and button wiring schematics for a set of machines. The goal is to determine the fewest button presses required to configure all indicator lights correctly according to the given diagrams. An indicator light diagram consists of '.' (off) and '#' (on), and each button can toggle the state of one or more specific indicator lights. You need to analyze each machine's configuration and calculate the total minimum button presses required for all machines.

## Input Format

Each line contains:<br>- An indicator light diagram in brackets `[...]`.<br>- Button wiring schematics in parentheses `(...)`, separated by spaces.<br>- Joltage requirements in curly braces `{...}` (which can be ignored).

## Output Format

An integer representing the fewest total button presses needed to configure all machines' indicator lights correctly.

## Sample Input

```
[.##.] (3) (1,3) (2) (2,3) (0,2) (0,1)
[...] (0,2,3,4) (2,3) (0,4) (0,1,2) (1,2,3,4)
[.###.#] (0,1,2,3,4) (0,3,4) (0,1,2,4,5) (1,2)
```

## Sample Output

```
7
```

## Note

for `[.##.] (3) (1,3) (2) (2,3) (0,2) (0,1)`
By pressing the last two buttons ((0,2) and (0,1)) once each.


for `[...#.] (0,2,3,4) (2,3) (0,4) (0,1,2) (1,2,3,4)`
By pressing the last three buttons ((0,4), (0,1,2), and (1,2,3,4)) once each.


for `[.###.#] (0,1,2,3,4) (0,3,4) (0,1,2,4,5) (1,2)`
By pressing buttons (0,3,4) and (0,1,2,4,5) once each.

So, the fewest button presses required to correctly configure the indicator lights on all of the machines is 2 + 3 + 2 = 7.