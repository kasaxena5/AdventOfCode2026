# Problem Statement

Given a set of devices and their connections in the form of output routes, calculate the number of unique paths from the device labeled 'you' to the device labeled 'out'. Each route denotes a connection from one device to others, and data only flows in the direction of the connections.

## Input Format

A list of strings, each representing a device and its outputs. The format is `<device>: <output1> <output2> ...`.

## Output Format

An integer representing the number of unique paths from 'you' to 'out'.

## Sample Input

```
aaa: you hhh
you: bbb ccc
bbb: ddd eee
ccc: ddd eee fff
ddd: ggg
eee: out
fff: out
ggg: out
hhh: ccc fff iii
iii: out
```

## Sample Output

```
5
```