#!/usr/bin/env python

# Testing default function
def sum(arg):
    total = 0
    for val in arg:
        total += val
    return total


def printNum(n):
    string = ""
    y = n
    while y > 0:
        string += str(n)
        # do something
        y -= 1

    return string


def printPat(n):
    """
    Given a number N. Print the pattern for the given value of N.
    Examples:
    N=2 the pattern would be:
    2 2 1 1
    2 1

    N=3 the pattern would be:
    3 3 3 2 2 2 1 1 1
    3 3 2 2 1 1
    3 2 1
    Args:
        n ([integer]): the number to be patternized
    """
    x = n
    string = ""
    #
    while n > 0:
        for i in range(x, 0, -1):
            for j in range(0, n):
                string += str(i)

        string += "\n"
        n -= 1

    print(string)


def findMaxConsecutiveOnes(nums) -> int:
    """
    Given a binary array, find the maximum number of consecutive 1s in this array.

    Args:
        nums (List[int]): the list to check for consecutive 1's

    Returns:
        int: total number of consecutive 1's in a list
    """
    maxCon = 0
    count = 0
    # iterate through list
    for x in nums:
        # check if current number equals 1
        if x == 1:
            count += 1
            # check if count total is greater then maximum consecutive count
            if count > maxCon:
                maxCon = count
        # if not 1, reset count
        else:
            count = 0

    return maxCon


def findNumbers(nums) -> int:
    """
    Given an array nums of integers,
    return how many of them contain an even number of digits.

    Args:
        nums (list): array of numbers

    Returns:
        int: count of how many list elements have an even number of digits
    """
    count = 0
    total = 0
    # for each item in list
    for x in nums:
        num = x

        # find the number of digits of list element
        while num > 0:
            count += 1
            num = num//10

        # check if current list item has an even number of digits
        if count % 2 == 0:
            total += 1

        # reset count for next list item
        count = 0

    return total


def sortedSquares(A):
    """
    Given an array of integers A sorted in non-decreasing order,
    return an array of the squares of each number,
    also in sorted non-decreasing order.

    Args:
        A ([type]): [description]
    """
    array = []

    # square each element in array and add to new list
    for x in A:
        square = x * x
        array.append(square)

    array.sort()

    print(array)
