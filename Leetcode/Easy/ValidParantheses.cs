namespace Leetcode.Easy;
public static class ValidParanthesesSolution {
    public static bool IsValid(string s) {
        if (s.Length == 0)
        {
            return true;
        }

        var openBrackets = new List<char> { '(', '[', '{' };
        var closeBrackets = new List<char> { ')', ']', '}' };

        var openedBrackets = new List<char>();

        foreach (var c in s)
        {
            if (openBrackets.Contains(c))
            {
                openedBrackets.Add(c);
            }

            if (!closeBrackets.Contains(c))
            {
                continue;
            }

            if (openedBrackets.Count == 0)
            {
                return false;
            }

            var lastOpenedBracket = openedBrackets[openBrackets.Count-1];

            if (closeBrackets.IndexOf(c) == openBrackets.IndexOf(lastOpenedBracket))
            {
                openedBrackets.RemoveAt(openedBrackets.Count - 1);
            }
            else
            {
                return false;
            }
        }

        return openedBrackets.Count == 0;
    }
}