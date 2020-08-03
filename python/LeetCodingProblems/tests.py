#!/usr/bin/env python

import unittest
import leet


class TestSum(unittest.TestCase):
    def test_list_int(self):
        """
        Test that it can sum a list of integers
        """
        data = [1, 2, 3]
        result = leet.sum(data)
        self.assertEqual(result, 6)


class TestConsecutive(unittest.TestCase):
    def test_consecutive(self):
        """
        Test that it can sum a list of integers
        """
        data = [0, 1, 1, 1, 0, 0, 1, 1]
        result = leet.findMaxConsecutiveOnes(data)
        self.assertEqual(result, 3)


class TestNumbers(unittest.TestCase):
    def test_consecutive(self):
        """
        Test that it can sum a list of integers
        """
        data = [3333, 444, 22, 3, 2345, 32, 333, 22123]
        result = leet.findNumbers(data)
        self.assertEqual(result, 4)


class TestMerged(unittest.TestCase):
    def test_consecutive(self):
        """
        Test that it can sum a list of integers
        """
        dataA = [1, 2, 3, 0, 0, 0]
        dataB = [2, 5, 6]
        result = leet.mergeSorted(dataA, dataB)
        self.assertEqual(result, [1, 2, 2, 3, 5, 6])


if __name__ == '__main__':
    unittest.main()
