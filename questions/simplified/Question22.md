# Problem Statement

You are given a list of devices and their outputs in the format of 'device: output1 output2'. Each device can send data to one or more other devices, and data flows only forward through the devices. Your task is to find all paths from the device named 'svr' (server rack) to the device 'out', ensuring that each path must also pass through the devices 'dac' and 'fft' in any order. Count how many such paths exist.

## Input Format

Each line contains a device with its outputs, formatted as 'device: output1 output2'. The input ends when there are no more lines.

## Output Format

An integer representing the number of valid paths from 'svr' to 'out' that visit both 'dac' and 'fft'.

## Sample Input

```
svr: aaa bbb
aaa: fft
fft: ccc
bbb: tty
tty: ccc
ccc: ddd eee
ddd: hub
hub: fff
eee: dac
dac: fff
fff: ggg hhh
ggg: out
hhh: out
```

## Sample Output

```
2
```