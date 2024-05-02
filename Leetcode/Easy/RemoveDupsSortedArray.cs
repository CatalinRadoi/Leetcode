namespace Leetcode.Easy;

internal class RemoveDupsSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var lastNumber = int.MinValue;
        var currentPos = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var currentNumber = nums[i];
            if (currentNumber!=  lastNumber)
            {
                lastNumber = currentNumber;
                nums[currentPos] = lastNumber;
                currentPos++;
            }
        }

        return currentPos;
    }
}