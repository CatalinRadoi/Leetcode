namespace Leetcode.Easy;

internal class Problem58
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        var lastIndexOfSpace = s.LastIndexOf(' ');
        if (lastIndexOfSpace == -1)
        {
            return s.Length;
        }

        return s.Substring(lastIndexOfSpace + 1, s.Length - lastIndexOfSpace - 1).Length;
    }
}