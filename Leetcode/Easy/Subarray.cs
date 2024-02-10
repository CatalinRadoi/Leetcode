//namespace Leetcode.Easy
//{
//    public class Solution {
//        public double FindMaxAverage(int[] nums, int k)
//        {
//            if (nums.Length <= k)
//            {
//                return (double)nums.Sum() / (double)k;
//            }

//            var max = int.MinValue;
//            for (int i = 0; i <= nums.Length - k; i++)
//            {
//                var sum = 0;
//                for (int j = i; j < k+i; j++)
//                {
//                    sum += nums[j];
//                }
//                max = Math.Max(max, sum);
//            }

//            var result = (double)max / (double)k;
//            return result;
//        }
//    }
//}
