// O(n*m)

using System.Collections;
string ransomNote = "asd";
string magazine = "dsgfdgjgghffkjghfghfjyufuyjmhgfa";

var sol = new Solution();
var res = sol.CanConstruct(ransomNote, magazine);
Console.WriteLine(ransomNote);
Console.WriteLine(magazine);
Console.WriteLine(res.ToString());
Console.ReadLine();
public class Solution
{
    Hashtable foundLetters;
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foundLetters = new Hashtable();
        for (int i = 0; i < ransomNote.Length; i++) 
        {
            FindLetter(magazine, ransomNote[i]);
        }
        if (foundLetters.Count > 0 && foundLetters.Count == ransomNote.Length)
            return true;
        return false;
    }
    bool FindLetter(string magazine, char letter)
    {
        int pos = magazine.IndexOf(letter);
        while(pos >= 0)
        {
            if (foundLetters.ContainsKey(pos))
            {
                pos = magazine.IndexOf(letter, pos+1);
            }
            else
            {
                foundLetters.Add(pos, letter);
                return true;
            }
        }
        return false;
    }
}
