using System.Collections;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        Hashtable ht = new Hashtable();
        int palindromeSize = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (ht.Contains(s[i]))
            {
                ht.Remove(s[i]);
                palindromeSize += 2;
            }
            else
            {
                ht.Add(s[i], i);
            }
        }
        if(ht.Count > 0)
        {
            palindromeSize++;
        }
        return palindromeSize;
    }
}