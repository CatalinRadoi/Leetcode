namespace Leetcode.Easy;
public static class LongestCommonPrefixSolution {
    public static string LongestCommonPrefix(string[] strs) {
         var output = string.Empty;
            var firstWord = strs[0];

            for (var i = firstWord.Length; i > 0; i--)
            {
                var candidate = firstWord[..i];
                if (strs.All(s => s.StartsWith(candidate)))
                {
                    return candidate;
                }
            }

            return output;
    }
}