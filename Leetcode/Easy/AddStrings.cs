namespace Leetcode.Easy;

internal class AddStringsClass
{
    public string AddStrings(string num1, string num2)
    {
        var carry = 0;
        num1 = ReverseString(num1);
        num2 = ReverseString(num2);
        var output = "";
        var head = 0;
        var t1 = 0;
        var t2 = 0;

        while (head < num1.Length || head < num2.Length )
        {
            t1 = head < num1.Length  ? Convert.ToInt32(num1.Substring(head, 1)) : 0;
            t2 = head < num2.Length  ? Convert.ToInt32(num2.Substring(head, 1)) : 0;
            var sum = t1 + t2 + carry;

            if (sum > 9)
            {
                carry = 1;
                sum -= 10;
            }
            else
            {
                carry = 0;
            }

            output += sum.ToString();
            head++;
        }

        var result = ReverseString(output);
        if (carry == 1)
        {
            result = "1" + result;
        }
        return result;
    }

    public static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Swap characters
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;

            // Move towards middle
            left++;
            right--;
        }

        return new string(charArray);
    }
}