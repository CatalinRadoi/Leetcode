namespace Leetcode.Medium;

internal static class Longest
{
    public static int LengthOfLongestSubstring(string s)
    {
        var queue = new Queue<char>();
        var r = 0;
        var longest = 0;


        while (r < s.Length)
        {
            
            while (!queue.Contains(s[r]))
            {
                queue.Enqueue(s[r]);
            
                r++;
                if (r == s.Length)
                {
                    break;
                }
            }

            if (queue.Count > longest)
            {
                longest = queue.Count;
            }

            if (r != s.Length)
            {
                while (queue.Peek() != s[r])
                {
                    queue.Dequeue();
                }

                queue.Dequeue();
            }
        }
     
        return longest;
    }
}