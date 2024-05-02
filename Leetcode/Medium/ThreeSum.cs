//namespace Leetcode.Medium;

//public class Solution
//{
//    public IList<IList<int>> ThreeSum(int[] nums)
//    {
//        var output = new List<IList<int>>();
//        for (var i = 0; i < nums.Length; i++)
//        {
//            var exista = TwoSum(nums, 0-nums[i],i);
//            if (exista != null)
//            {
//                var list = new List<int> { nums[i], exista[0], exista[1] };
//                output.Add(list);
//            }
//        }
//        return RemoveDuplicates(output);
//    }

//    private List<int[]>? TwoSum(int[] nums, int target, int ignoreIndex)
//    {
//        // problema e ca asta imi intoarce prima pereche gasita, nu toate.

//        var output = new List<int[]>();
//        for (var index = 0; index < nums.Length; index++)
//        {
//            if (index == ignoreIndex)
//            {
//                continue;
//            }
//            var num = nums[index];
//            var d = target - num;
//            var frateleMeuIndex = Array.IndexOf(nums, d);
//            if (frateleMeuIndex != -1 && frateleMeuIndex != index && frateleMeuIndex != ignoreIndex)
//            {
//                output.Add(new[] { num, nums[frateleMeuIndex] });
//            }
//        }

//        return null;
//    }

//    public static IList<IList<int>> RemoveDuplicates(IList<IList<int>> output)
//    {
//        HashSet<IList<int>> uniqueLists = new HashSet<IList<int>>(new ListComparer());
//        List<IList<int>> result = new List<IList<int>>();

//        foreach (IList<int> list in output)
//        {
//            if (uniqueLists.Add(list))
//            {
//                result.Add(list);
//            }
//        }

//        return result;
//    }
//}
//class ListComparer : IEqualityComparer<IList<int>>
//{
//    public bool Equals(IList<int> x, IList<int> y)
//    {
//        if (x.Count != y.Count)
//            return false;

//        List<int> sortedX = new List<int>(x);
//        List<int> sortedY = new List<int>(y);

//        sortedX.Sort();
//        sortedY.Sort();

//        for (int i = 0; i < sortedX.Count; i++)
//        {
//            if (sortedX[i] != sortedY[i])
//                return false;
//        }

//        return true;
//    }

//    public int GetHashCode(IList<int> obj)
//    {
//        unchecked
//        {
//            int hash = 17;
//            List<int> sortedList = new List<int>(obj);
//            sortedList.Sort();
//            foreach (int value in sortedList)
//            {
//                hash = hash * 23 + value;
//            }
//            return hash;
//        }
//    }
//}