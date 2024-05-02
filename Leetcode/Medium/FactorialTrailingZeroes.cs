//namespace Leetcode.Medium
//{
//    public class Solution {
//        public int TrailingZeroes(int n)
//        {
//            var zeros = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                var current = i;
//                while (current % 5 == 0)
//                {
//                    zeros++;
//                    current /= 5;
//                }
//            }
//            return zeros;
//        }
//    }
//}
