namespace Leetcode.Medium
{
    internal class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k) {
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dic.TryAdd(num, 1))
                {
                    dic[num]++;
                }
            }

            return dic.OrderByDescending(x => x.Value).Select(kvp => kvp.Key).Take(k).ToArray();
        }
    }
}
