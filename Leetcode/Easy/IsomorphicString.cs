namespace Leetcode.Easy;

internal class IsomorphicString
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                if (dict[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (dict.ContainsValue(t[i]))
                {
                    return false;
                }
                dict.Add(s[i], t[i]);
            }

        }

        return true;
    }
}