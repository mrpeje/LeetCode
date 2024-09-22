// O(n)
string stringParantheses = "(])";

var sol = new Solution();
var res = sol.IsValid(stringParantheses);
Console.WriteLine(stringParantheses);

Console.WriteLine(res.ToString());
Console.ReadLine();
public class Solution
{
    Dictionary<char, char> ParantheseDict;

    public bool IsValid(string s)
    {
        ParantheseDict = new Dictionary<char, char>();
        ParantheseDict.Add('(', ')');
        ParantheseDict.Add('[', ']');
        ParantheseDict.Add('{', '}');

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var currentChar = s[i];
            if(IsOpenParantheses(currentChar))
            {
                stack.Push(currentChar);
            }
            if(IsClosedParantheses(currentChar))
            {
                if(stack.Count == 0)
                    return false;
                var stackPeek = stack.Peek();
                if (GetCloseParanthese(stackPeek) == currentChar)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    char GetCloseParanthese(char c)
    {
        ParantheseDict.TryGetValue(c, out char paranthese);
        return paranthese;
    }
    bool IsOpenParantheses(char checkChar)
    {
        
        for (int i = 0;i < ParantheseDict.Keys.Count;i++) 
        {
            if( ParantheseDict.Keys.Contains(checkChar) )
            {
                return true;
            }    
        }
        return false;
    }     

    bool IsClosedParantheses(char checkChar)
    {        
        for (int i = 0;i < ParantheseDict.Values.Count; i++) 
        {
            if( ParantheseDict.Values.Contains(checkChar) ) 
            {
                return true;
            }    
        }
        return false;
    }
}