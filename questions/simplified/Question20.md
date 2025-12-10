# Problem Statement

You are given a list of machines, and for each machine, its configuration consists of button wiring schematics and joltage requirements. The goal is to determine the fewest button presses needed to achieve the specified joltage levels for all machines. Each machine's configuration is expressed in the following format:

- Button schematics represented as indices of lights that each button can increase joltage by 1 for, enclosed in parentheses.
- Joltage requirements represented as a list of target values inside curly braces.

You need to Compute the minimum button presses required to achieve the joltage requirements.

Finally, output the total minimum button presses required for all machines combined.

## Input Format

Each line of input represents one machine's configuration in the format `(*button schematics*){(*joltage requirements*)}`.

- `*button schematics*`: One or more button descriptions in parentheses.
- `{*joltage requirements*}`: A list of integers enclosed in curly braces.

## Output Format

An integer representing the total minimum button presses required for all machines' configurations.

## Sample Input

```
(3) (1,3) (2) (2,3) (0,2) (0,1) {3,5,4,7}
(0,2,3,4) (2,3) (0,4) (0,1,2) (1,2,3,4) {7,5,12,7,2}
(0,1,2,3,4) (0,3,4) (0,1,2,4,5) (1,2) {10,11,11,5,10,5}
```

## Sample Output

```
33
```

## Note
Configuring the first machine's counters requires a minimum of 10 button presses. One way to do this is by pressing (3) once, (1,3) three times, (2,3) three times, (0,2) once, and (0,1) twice.

Configuring the second machine's counters requires a minimum of 12 button presses. One way to do this is by pressing (0,2,3,4) twice, (2,3) five times, and (0,1,2) five times.

Configuring the third machine's counters requires a minimum of 11 button presses. One way to do this is by pressing (0,1,2,3,4) five times, (0,1,2,4,5) five times, and (1,2) once.

So, the fewest button presses required to correctly configure the joltage level counters on all of the machines is 10 + 12 + 11 = 33.