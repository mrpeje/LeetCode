// O()
using System.Collections;

var nums = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
var nums1 = new int[] {-4,-3,-2,-1,-1,0,0,1,2,3,4 };

var sol = new Solution();
var res = sol.ThreeSum(nums);
foreach (var line in res)
{
    var str = "";
    foreach (var item in line)
        str += item.ToString() + ", ";
    Console.WriteLine(str);
}


Console.ReadLine();
public class Solution
{
    Hashtable Hashtable = new Hashtable();
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int[] sortedNums = Sort(nums.ToList());
        int start = 0, left, right;

        /*The target is that the number we are looking for to be composed out of 2 numbers from our array.
        for example, if we have the startIndex at -4, we are looking for those two numbers in the given array
        which, summed up will be the oposite of -4, which is 4, cuz -4 + 4 = 0 (duh) */
        int target;

        /*The start goes from 0 to length-2 becuse look here
         -4 -2 -3 -1 0 0 0 2 3 10 21
                             s  l  r      */
        while (start < sortedNums.Length - 2)
        {
            target = sortedNums[start] * -1;
            left = start + 1;
            right = sortedNums.Length - 1;

            /*Now, the start index is fixed and we move the left and right indexes to find those two number
            which summed up will be the oposite of nums[s]  */
            while (left < right)
            {
                /*The array is sorted, so if we move to the left the right index, the sum will decrese */
                if (sortedNums[left] + sortedNums[right] > target)
                {
                    --right;
                }

                /*Here is the oposite, it the sum of nums[l] and nums[r] is less that what we are looking for,
                then we move the left index, which means that the sum will increase due to the sorted array.
                the left index will jump to a bigger value */
                else if (sortedNums[left] + sortedNums[right] < target)
                {
                    ++left;
                }
                /*If none of those are true, then it means that nums[l]+nums[r] = our desired value */
                else
                {
                    /*Here we create the solution and add it to the list of lists which contains the result. */
                    List<int> OneSolution = new List<int>() { sortedNums[start], sortedNums[left], sortedNums[right] };
                    result.Add(OneSolution);

                    /*Now, in order to generate different solutions, we have to jump over
                    repetitive values in the array.  */
                    while (left < right && sortedNums[left] == OneSolution[1])
                        ++left;
                    while (left < right && sortedNums[right] == OneSolution[2])
                        --right;
                }

            }
            /*Now we do the same thing to the start index. */
            int currentStartNumber = sortedNums[start];
            while (start < sortedNums.Length - 2 && sortedNums[start] == currentStartNumber)
                ++start;
        }
        return result;
    }

    private int[] Sort(List<int> nums)
    {
        int[] sortNums = nums.ToArray();
        for(int i = 0; i < nums.Count; i++)
        {
            Hashtable[nums[i]] = true;
            for (int j = 0; j < nums.Count; j++)
            {
                if (sortNums[i] < sortNums[j])
                {
                    var tmp = sortNums[i];
                    sortNums[i] = sortNums[j];
                    sortNums[j] = tmp;
                }
            }
        }
        return sortNums.ToArray();
    }    
}
