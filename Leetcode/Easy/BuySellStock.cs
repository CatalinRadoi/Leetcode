//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Leetcode.Easy
//{
//    public int MaxProfit(int[] prices) {
//        var l = 0;
//        var r = prices.Length - 1;
//        var max = 0;
//        while (l < r)
//        {
//            var profit = prices[r] - prices[l];
//            if (profit > max)
//            {
//                max = profit;
//            }

//            if (prices[l] > prices[l + 1])
//            {
//                l++;
//            }
//            else
//            {
//                r--;
//            }
//        }
//        return max;
//    }
//}
