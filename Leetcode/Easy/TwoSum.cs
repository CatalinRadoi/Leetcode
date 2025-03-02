using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hashMap = new Dictionary<int, int>(); // value, pos
            for (int i = 0; i < nums.Length; i++)
            {
                var reminder = target - nums[i];
                if (hashMap.ContainsKey(reminder))
                {
                    return [i, hashMap[reminder]];
                }

                if (!hashMap.ContainsKey(nums[i]))
                {
                    hashMap.Add(nums[i], i);
                }

            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
