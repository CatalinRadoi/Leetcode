//using System.Text;

//namespace Leetcode.Easy;

//public class Solution
//{
//    public bool IsPalindrome(string s)
//    {
//        if (s == null || s.Length == 0 || s.Length == 1)
//        {
//            return true;
//        }

//        var reversed = RemoveSpecialCharacters(
//            s.ToLower().Replace(" ", string.Empty));

//        var dero = Reverse(reversed);
//        return reversed == dero;
//    }

//    public static string RemoveSpecialCharacters(string str)
//    {
//        StringBuilder sb = new StringBuilder();
//        foreach (char c in str)
//        {
//            if (c is >= 'a' and <= 'z' or >= '0' and <= '9')
//            {
//                sb.Append(c);
//            }
//        }
//        return sb.ToString();
//    }

//    public static string Reverse( string s )
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}