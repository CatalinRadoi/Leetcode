namespace Leetcode.Easy;

internal class PlusOnner
{
   

    public bool IsPowerOfTwo(int n) {
        if (n > 1)
        {
            while (n % 2 == 0)
            {
                n = n / 2;
            }
        }
        return n == 1;
    }
}