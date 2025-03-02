namespace Leetcode.Easy
{
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            return IsPalindrome(x.ToString());
        }

        private bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i-1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
