namespace Leetcode.Medium
{
    internal class InterleavingStrings
    {
        // 2d boolean array where dp[i][j] indicates whether the substring s3(0,i+j) can be formed
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            var dp = new bool[s1.Length + 1, s2.Length + 1];
            dp[0, 0] = true;

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i > 0 && s1[i - 1] == s3[i + j - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                    }

                    if (j > 0 && s2[j - 1] == s3[i + j - 1])
                    {
                        dp[i, j] = dp[i, j] || dp[i, j - 1];
                    }
                }
            }
            return dp[s1.Length, s2.Length];
        }
    }
}
