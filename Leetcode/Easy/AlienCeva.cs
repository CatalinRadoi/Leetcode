using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class AlienCeva
    {
        public bool IsAlienSorted(string[] words, string order)
        {

            var index = -1;
            var aceeasiPrimaLitera = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (order.IndexOf(words[i][0]) < index)
                {
                    return false;
                }

                if (i != 0)
                {

                }
                index = order.IndexOf(words[i][0]);
                words[i] = words[i].Substring(1);
            }



            if (words.Any(w => w.Length > 0))
            {
                return IsAlienSorted(words.Where(w => w.Length > 0).ToArray(), order);
            }

            return true;
        }
    }
}
