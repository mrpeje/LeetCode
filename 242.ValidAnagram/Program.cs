// O(n)
using System.Collections;
var solution = new Solution();
var res = solution.IsAnagram("baba", "baab");
Console.WriteLine(res);
Console.ReadLine();
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) 
            return false;

        Dictionary<char, int> htS = new Dictionary<char, int>();
        Dictionary<char, int> htT = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if (htS.ContainsKey(s[i]))
                htS[s[i]]++;
            else
                htS.Add(s[i], 1);
            if (htT.ContainsKey(t[i]))
                htT[t[i]]++;
            else
                htT.Add(t[i], 1);
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (htS.ContainsKey(s[i]) && htT.ContainsKey(s[i]))
            {
                if (htS[s[i]] != htT[s[i]])
                    return false;
            }
            else
                return false;
        }
        return true;
    }
}