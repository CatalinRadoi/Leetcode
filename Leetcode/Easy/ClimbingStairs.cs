namespace Leetcode.Easy;

internal class ClimbingStairs
{
    Dictionary<int, int> memo = new();


    public int ClimbStairs(int n) {
        if (n <= 2)
        {
            return n;
        }

        if (memo.TryGetValue(n, out var stairs))
        {
            return stairs;
        }
        var value = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        memo[n] = value;

        return value;
    }

}