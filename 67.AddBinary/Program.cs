// O(n)
string A = "11";
string B = "1";
var solution = new Solution();
string res = solution.AddBinary(A, B);
Console.WriteLine(res);
Console.ReadLine();
public class Solution
{
    public string AddBinary(string a, string b)
    {
        var sumLen = 0;
        var Remainder = 0;
        string zeroStr = "";
        if (a.Length > b.Length)
        {
            sumLen = a.Length;
            var addZero = a.Length - b.Length;
            for (int i = 0; i < addZero; i++)
                zeroStr += "0";
            b = zeroStr + b;
        }
        else
        {
            sumLen = b.Length;
            var addZero = b.Length - a.Length;
            for (int i = 0; i < addZero; i++)
                zeroStr += "0";
            a = zeroStr + a;
        }
        string result = "";
        for (int i = sumLen - 1; i >= 0; i--)
        {
            int bitA = (int)Char.GetNumericValue(a[i]);
            int bitB = (int)Char.GetNumericValue(b[i]);

            int currentSum = bitA + bitB + Remainder;
            string currentBitValue = "";
            if (currentSum == 3)
            {
                currentBitValue = "1";
                Remainder = 1;
            }
            if ((currentSum) == 2)
            {
                currentBitValue = "0";
                Remainder = 1;
            }
            if (currentSum == 1)
            {
                currentBitValue = "1";
                Remainder = 0;
            }
            if (currentSum == 0)
            {
                currentBitValue = "0";
                Remainder = 0;
            }

            result += currentBitValue;
        }
        if(Remainder == 1)
        {
            result += "1";
        }
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
