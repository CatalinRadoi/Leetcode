namespace Leetcode.Easy;
public class FindTheDifferenceSolution
{
    public char FindTheDifference(string s, string t)
    {
        var hashMap = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (hashMap.ContainsKey(c))
            {
                hashMap[c]++;
            }
            else
            {
                hashMap[c] = 1;
            }
        }
        foreach (var c in t)
        {
            if (hashMap.ContainsKey(c))
            {
                hashMap[c]--;
                if (hashMap[c] < 0)
                {
                    return c;
                }
            }
            else
            {
                return c;
            }
        }
        return 'a';
    }
}