//using Microsoft.Win32.SafeHandles;

//namespace Leetcode.Easy;

//public class Solution
//{
//    public List<Int32> sazis = new List<int>();
//    public bool IsHappy(int n)
//    {
//        if (sazis.Contains(n))
//        {
//            return false;
//        }
//        sazis.Add(n);
//        var numberString = n.ToString();

//        var digits = new int[numberString.Length];

//        for (var i = 0; i < numberString.Length; i++)
//        {
//            digits[i] = int.Parse(numberString[i].ToString());
//        }

//        var sum = digits.Sum(cifra => Convert.ToInt32(Math.Pow(Convert.ToDouble(cifra), 2)));

//        return sum == 1 || IsHappy(sum);
//    }
//}