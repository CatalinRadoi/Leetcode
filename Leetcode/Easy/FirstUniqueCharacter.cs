using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            var charCount = new Dictionary<char, (int count, int index)>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                {
                    var current = charCount[s[i]];
                    charCount[s[i]] = (current.count + 1, current.index);
                }
                else
                {
                    charCount[s[i]] = (1, i);
                }
            }

            return charCount.Values.Where(v => v.count == 1)
                           .Select(v => v.index)
                           .DefaultIfEmpty(-1)
                           .Min();
        }
    }
}
