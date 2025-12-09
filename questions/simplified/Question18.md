# Problem Statement

Given a list of coordinates of red tiles in a grid, each red tile is connected to the next red tile by green tiles, the tiles wraps around, meaning the last red tile is connected to the first one. Tiles adjacent in the input list are either in the same row or column. All the tiles inside the loop (polygon) formed from the above green and red tiles are green and outside the loop are transparent. Find the largest rectangular area that can be formed using red tiles as opposite corners and red or green tiles for the rest of the rectangle i.e all tiles inside the formed rectangle must also be red or green.

## Input Format

A list of coordinates representing the red tiles in the format x,y where both x and y are integers.

## Output Format

An integer representing the largest area of the rectangle that can be formed using red and green tiles.

## Sample Input

```
7,1
11,1
11,7
9,7
9,5
2,5
2,3
7,3
```

## Sample Output

```
24
```

## Note
The above input corresponds to the following grid, here `#` are red tiles and `X` are green tiles and `.` are transparent tiles.
```
..............
.......#XXX#..
.......XXXXX..
..#XXXX#XXXX..
..XXXXXXXXXX..
..#XXXXXX#XX..
.........XXX..
.........#X#..
..............
```