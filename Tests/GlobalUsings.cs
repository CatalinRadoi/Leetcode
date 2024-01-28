public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        foreach (var c in ransomNote)
        {
            var index = magazine.IndexOf(c);
            if (index == -1)
            {
                return false;
            }
            magazine = magazine.Remove(index, 1);
        }

        return true;
    }
}