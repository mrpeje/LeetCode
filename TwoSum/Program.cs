// O(n)

using System.Collections;

int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
int target = 11;
var sol = new Solution();
var res = sol.TwoSum(nums, target);
Console.WriteLine(nums[res[0]] + " + " + nums[res[1]] + " = " + target);
Console.ReadLine();
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable hash = new Hashtable();
        int[] result = new int[2];
        for(int i = 0;  i < nums.Length; i++)
        {
            var compliment = target - nums[i];
            if (hash.ContainsKey(compliment))
            {
                result[0] = i; 
                result[1] = (int)hash[compliment];
            }
            else
            {
                hash[nums[i]] = i;
            }
        }
        return result;
    }
}