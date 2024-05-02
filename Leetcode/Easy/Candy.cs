using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class Candy
    {

        public int DistributeCandies(int[] candyType)
        {
            var hashMap = new Dictionary<int, int>();
            foreach (var candy in candyType)
            {
                if (!hashMap.TryAdd(candy, 1))
                {
                    hashMap[candy]++;
                }
            }

            var half = candyType.Length / 2;
            return half >= hashMap.Count ? hashMap.Count : half;
        }
    }
}
