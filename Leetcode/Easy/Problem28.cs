using System.Runtime.ExceptionServices;

namespace Leetcode.Easy;

internal class Problem28
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        var match = false;
        for (var i = 0; i < haystack.Length; i++)
        {
            if (i + needle.Length > haystack.Length)
            {
                return -1;
            }
            for (var j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }

                match = true;
            }

            if (match)
            {
                return i;
            }
        }

        return -1;
    }
}