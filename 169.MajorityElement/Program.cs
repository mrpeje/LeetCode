using System;
using System.Collections;
var nums = new int[] { 6, 5, 5 };

var sol = new Solution();
var res = sol.MajorityElement(nums);
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var ht = new Dictionary<int, int>();
        var major = (nums[0], 1);
        for (int i = 0; i < nums.Length; i++)
        {
            if (ht.ContainsKey(nums[i]))
            {
                ht[nums[i]]++;
                if (major.Item2 < ht[nums[i]])
                {
                    major.Item1 = nums[i];
                    major.Item2 = ht[nums[i]];

                }
            }
            else
                ht[nums[i]] = 1;
        }
        return major.Item1;
    }
}
