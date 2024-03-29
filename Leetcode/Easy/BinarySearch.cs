﻿namespace Leetcode.Easy;

internal class BinarySearch
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        if (nums[left] == target)
        {
            return left;
        }

        if (nums[right] == target)
        {
            return right;
        }

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}