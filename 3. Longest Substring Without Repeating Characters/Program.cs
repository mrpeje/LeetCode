using System.Collections;

// O(n)
using System.Collections;
var solution = new Solution();
var res = solution.LengthOfLongestSubstring("dvdf");
Console.WriteLine(res);
Console.ReadLine();

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if(s.Length == 0)
            return 0;
        Hashtable hashtable = new Hashtable();
        int currentMax = 0;
        int prevMax = 0;

        for (int j = 0; j < s.Length; j++)
        {
            if (prevMax > s.Length - j)
                break;
            for (int i = j; i < s.Length; i++)
            {
                if (hashtable.ContainsKey(s[i]))
                {

                    break;
                }
                else
                {
                    hashtable.Add(s[i], i);
                    currentMax++;
                }
            }
            if (prevMax < currentMax)
                prevMax = currentMax;
            currentMax = 0;
            hashtable.Clear();
        }
        if (prevMax < currentMax)
            return currentMax;
        else
            return prevMax;
    }
}