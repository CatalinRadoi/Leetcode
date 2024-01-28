namespace Leetcode.Medium
{
    internal class GroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var  anagrams = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var sortedStr = new string(chars);

                if (!anagrams.ContainsKey(sortedStr))
                {
                    anagrams.Add(sortedStr, new List<string>() {str});
                }
                else
                {
                    anagrams[sortedStr].Add(str);
                }
            }
            return anagrams.Values.ToList<IList<string>>();
        }
    }
}
